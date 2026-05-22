IF OBJECT_ID('dbo.classifications', 'U') IS NULL
BEGIN
    CREATE TABLE classifications (
        class_id    INT IDENTITY NOT NULL,
        class_name  VARCHAR(50) UNIQUE NOT NULL,

        PRIMARY KEY (class_id)
        );
END


IF OBJECT_ID('dbo.countries', 'U') IS NULL
BEGIN
    CREATE TABLE countries (
        country_id      INT IDENTITY NOT NULL,
        country_name    VARCHAR(60) UNIQUE NOT NULL,

        PRIMARY KEY (country_id)
        );
END


IF OBJECT_ID('dbo.sections', 'U') IS NULL
BEGIN
    CREATE TABLE sections (
        section_id      INT IDENTITY NOT NULL,
        section_name    VARCHAR(30) UNIQUE NOT NULL,

        PRIMARY KEY (section_id)
        );
END


IF OBJECT_ID('dbo.minerals', 'U') IS NULL
BEGIN
    CREATE TABLE minerals (
        mineral_tag     VARCHAR(12) NOT NULL,
        mineral_name    VARCHAR(45) NOT NULL,
        chem_formula    VARCHAR(90) NOT NULL,
        class_id        INT NOT NULL,
        country_id      INT NOT NULL,
        section_id      INT NOT NULL,
        dimensions      VARCHAR(30) NOT NULL,
        hardness_lvl    INT NOT NULL CHECK (hardness_lvl BETWEEN 1 AND 10),
        mineral_desc    VARCHAR(500) NOT NULL,
        is_fluorescent  BIT NOT NULL DEFAULT 0,
        is_radioactive  BIT NOT NULL DEFAULT 0,
        date_added      DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

        PRIMARY KEY (mineral_tag),
        FOREIGN KEY (class_id)
            REFERENCES classifications(class_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE,
        FOREIGN KEY (country_id)
            REFERENCES countries(country_id)
            ON UPDATE CASCADE,
        FOREIGN KEY (section_id)
            REFERENCES sections(section_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE
        );
END


IF OBJECT_ID('dbo.positions', 'U') IS NULL
BEGIN
    CREATE TABLE positions (
        position_id     INT IDENTITY(201, 1) NOT NULL,
        position_title  VARCHAR(20) UNIQUE NOT NULL,

        PRIMARY KEY (position_id)
        );
END


IF OBJECT_ID('dbo.employees', 'U') IS NULL
BEGIN
    CREATE TABLE employees (
        employee_id     INT IDENTITY(301, 1) NOT NULL,
        first_name      VARCHAR(35) NOT NULL,
        last_name       VARCHAR(45) NOT NULL,
        gender          VARCHAR(6) NOT NULL CHECK (gender IN ('female', 'male')),
        date_of_birth   DATE NOT NULL CHECK (date_of_birth <= DATEADD(YEAR, -18, GETDATE())),
        hire_date       DATE NOT NULL CHECK (hire_date <= GETDATE()),
        email           VARCHAR(50) UNIQUE NOT NULL,
        phone_num       VARCHAR(17) UNIQUE NOT NULL,
        home_addr       VARCHAR(150) NOT NULL,
        monthly_salary  DECIMAL(7, 2) NOT NULL CHECK (monthly_salary > 0),
        position_id     INT NOT NULL,
        is_active       BIT NOT NULL DEFAULT 1,     -- setting this to 0 means the employee was fired so their account gets deleted

        PRIMARY KEY (employee_id),
        FOREIGN KEY (position_id)
            REFERENCES positions(position_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE
            -- just be careful when deleting positions. ensure they understand that deleting a position
            -- that has employees means all employees will be deleted
        );
END


IF OBJECT_ID('dbo.users', 'U') IS NULL
BEGIN
    CREATE TABLE users (
        username        VARCHAR(30) UNIQUE NOT NULL,
        password_hash   VARCHAR(100) NOT NULL,
        created_at      DATETIME2 NOT NULL DEFAULT SYSDATETIME() CHECK (created_at <= SYSDATETIME()),
        last_login      DATETIME2 NULL CHECK (last_login <= SYSDATETIME()), -- the user might've never logged in yet
        employee_id     INT NOT NULL,

        PRIMARY KEY (username),
        FOREIGN KEY (employee_id)
            REFERENCES employees(employee_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE
            -- if for some reason an employee is ever deleted (they always get archived), their user gets deleted
        );
END


IF OBJECT_ID('dbo.guests', 'U') IS NULL
BEGIN
    CREATE TABLE guests (
        guest_id        INT IDENTITY(401, 1) NOT NULL,
        first_name      VARCHAR(35) NOT NULL,
        last_name       VARCHAR(45) NOT NULL,
        gender          VARCHAR(6) NOT NULL CHECK (gender IN ('female', 'male')),
        email           VARCHAR(50) UNIQUE NULL,
        phone_num       VARCHAR(17) UNIQUE NOT NULL,
        registered_at   DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

        PRIMARY KEY (guest_id)
        );
END


IF OBJECT_ID('dbo.events', 'U') IS NULL
BEGIN
    CREATE TABLE events (
        event_id        INT IDENTITY(501, 1) NOT NULL,
        event_name      VARCHAR(45) UNIQUE NOT NULL,
        total_guests    INT NOT NULL CHECK (total_guests >= 0),
        event_status    VARCHAR(10) NOT NULL,
        event_date      DATE NOT NULL,
        start_time      TIME NOT NULL CHECK (start_time >= '08:00:00' AND start_time <= '23:00:00'),
        end_time        TIME NOT NULL,

        --inline CHECK constraints may only reference the same column. therefore, some constraints have been added separately
        CONSTRAINT events_end_time_chk CHECK (end_time > start_time),
        PRIMARY KEY (event_id)
        );
END


IF OBJECT_ID('dbo.events_employees', 'U') IS NULL
BEGIN
    CREATE TABLE events_employees (
        event_id    INT NOT NULL,
        employee_id INT NOT NULL,

        PRIMARY KEY (event_id, employee_id),
        FOREIGN KEY (event_id)
            REFERENCES events(event_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE,
        FOREIGN KEY (employee_id)
            REFERENCES employees(employee_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE
        );
END


IF OBJECT_ID('dbo.events_attendees', 'U') IS NULL
BEGIN
    CREATE TABLE events_attendees (
        event_id INT NOT NULL,
        guest_id INT NOT NULL,

        PRIMARY KEY (event_id, guest_id),
        FOREIGN KEY (event_id)
            REFERENCES events(event_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE,
        FOREIGN KEY (guest_id)
            REFERENCES guests(guest_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE
        );
END


IF OBJECT_ID('dbo.donations', 'U') IS NULL
BEGIN
    CREATE TABLE donations (
        donation_id     INT IDENTITY(601, 1) NOT NULL,
        donor_id        INT NULL, --NULL = anonymous
        amount          DECIMAL(13, 2) NOT NULL CHECK (amount > 0),
        donation_type   VARCHAR(20) NOT NULL DEFAULT 'standard',
        donation_date   DATE NOT NULL CHECK (donation_date <= GETDATE()),
        note            VARCHAR(45) NULL DEFAULT 'N/A',
        event_id        INT NULL,

        CONSTRAINT donation_event_logic CHECK (
            (donation_type = 'event' AND event_id IS NOT NULL)
            OR
            (donation_type = 'standard' AND event_id IS NULL)
            ),

        PRIMARY KEY (donation_id),
        FOREIGN KEY (donor_id)
            REFERENCES guests(guest_id)
            ON UPDATE CASCADE
            ON DELETE SET NULL,  -- donor_id is already nullable, so if a guest is deleted a donation becomes anonymous
        FOREIGN KEY (event_id)
            REFERENCES events(event_id)
            ON UPDATE CASCADE
        );
END

/*
Most transactions will be anonymous walk-ins.
The rare case where they collect customer info (maybe for large purchases, special orders, or loyalty tracking)
is why this table exists.
*/
IF OBJECT_ID('dbo.customers', 'U') IS NULL
BEGIN
    CREATE TABLE customers (
        customer_id     INT IDENTITY(701, 1) NOT NULL,
        first_name      VARCHAR(35) NOT NULL,
        last_name       VARCHAR(45) NOT NULL,
        gender          VARCHAR(6) NOT NULL CHECK (gender IN ('female', 'male')),
        email           VARCHAR(50) UNIQUE NULL,
        phone_num       VARCHAR(17) UNIQUE NOT NULL,
        registered_at   DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

        PRIMARY KEY (customer_id)
        );
END


IF OBJECT_ID('dbo.boutique_items', 'U') IS NULL
BEGIN
    CREATE TABLE boutique_items (
        item_id         INT IDENTITY(801, 1) NOT NULL,
        item_name       VARCHAR(60) NOT NULL,
        unit_price      DECIMAL(7, 2) NOT NULL CHECK (unit_price > 0),
        quantity        INT NOT NULL DEFAULT 1 CHECK (quantity >= 0),
        date_added      DATE NOT NULL CHECK (date_added <= GETDATE()),
        ref_mineral     VARCHAR(12) NULL, -- the mineral it's made of may not exist in our collection of minerals
        image_filename  VARCHAR(100) NULL,
        is_active  BIT NOT NULL DEFAULT 1,

        PRIMARY KEY (item_id),
        FOREIGN KEY (ref_mineral)
            REFERENCES minerals(mineral_tag)
            ON UPDATE CASCADE
            ON DELETE SET NULL  -- if a mineral is deleted, the item stays but loses mineral reference
        );
END


IF OBJECT_ID('dbo.transactions', 'U') IS NULL
BEGIN
    CREATE TABLE transactions (
        trans_uuid      UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
        customer_id     INT NULL,                                       -- NULL = walk-in, no info collected
        subtotal        DECIMAL(7, 2) NOT NULL CHECK (subtotal > 0),    -- sum of items                              ex:  $37.00
        vat             DECIMAL(7, 2) NOT NULL CHECK (vat >= 0),        -- 11% of subtotal                           ex:  $4.07
                                            -- could be 0 if subtotal somehow exempt
        total           DECIMAL(7, 2) NOT NULL CHECK (total > 0),       -- subtotal + vat                           ex:  $41.07
        payment_method  VARCHAR(20) NOT NULL DEFAULT 'cash',            --  ex:  cash
        amount_paid     DECIMAL(7, 2) NULL,         -- how much the customer paid (for cash)                        ex:  $50.00
        change_due      DECIMAL(7, 2) NULL,         -- change to return (for cash)                                  ex:  $8.93
        created_at      DATETIME2 NOT NULL DEFAULT SYSDATETIME() CHECK (created_at <= SYSDATETIME()),
        employee_id     INT NOT NULL,

        -- payment logic constraints
        CONSTRAINT chk_payment_logic CHECK (
            (payment_method = 'cash' AND amount_paid IS NOT NULL AND change_due IS NOT NULL)
            OR
            (payment_method = 'card' AND amount_paid IS NULL AND change_due IS NULL)
            ),

        -- if cash payment, customer must pay at least the total amount
        CONSTRAINT chk_cash_sufficient CHECK (
            payment_method = 'card' 
            OR 
            (payment_method = 'cash' AND amount_paid >= total)
            ),

        CONSTRAINT chk_change_correct CHECK (
            payment_method = 'card'
            OR
            (payment_method = 'cash' AND change_due = (amount_paid - total))
            ),

        PRIMARY KEY (trans_uuid),
        FOREIGN KEY (customer_id)
            REFERENCES customers(customer_id)
            ON UPDATE CASCADE
            ON DELETE SET NULL,  -- if a customer is deleted, the transaction stays but loses customer reference
        FOREIGN KEY (employee_id)
            REFERENCES employees(employee_id)
            ON UPDATE CASCADE
        );
END

/*
## 3. `item_price` in `transaction_items`

**The problem without it:**
```
Day 1: Hematite Pendant costs $25.00
       Customer buys 2 → transaction_items: item_id=801, quantity=2

Day 30: Manager raises price to $35.00
        boutique_items: item_id=801, unit_price=35.00  ← UPDATED

Day 31: Manager runs "Sales Report for last month"
        Query joins transaction_items with boutique_items to get price
        Gets $35.00 × 2 = $70.00 ← WRONG! Should be $25.00 × 2 = $50.00
*/

IF OBJECT_ID('dbo.transaction_items', 'U') IS NULL
BEGIN
    CREATE TABLE transaction_items (
        trans_uuid  UNIQUEIDENTIFIER NOT NULL,
        item_id     INT NOT NULL,
        quantity    INT NOT NULL DEFAULT 1 CHECK (quantity > 0),
        item_price  DECIMAL(7, 2) NOT NULL CHECK (item_price > 0), -- price at time of purchase (price snapshot)
                                           -- without this, changing a `boutique_item`'s `unit_price` later
                                           -- will result in wrong prices in historical transaction reports

        PRIMARY KEY (trans_uuid, item_id), -- prevents the same item from appearing twice. therefore, we rely on the `quantity` column for the quantity
        FOREIGN KEY (trans_uuid)
            REFERENCES transactions(trans_uuid)
            ON UPDATE CASCADE
            ON DELETE CASCADE,

        FOREIGN KEY (item_id)
            REFERENCES boutique_items(item_id)
            ON UPDATE CASCADE
            -- no on delete rule so you can never really delete it from the database, just archive it
        );
END


IF OBJECT_ID('dbo.items_categories', 'U') IS NULL
BEGIN
    CREATE TABLE items_categories (
        category_id     INT IDENTITY(901, 1) NOT NULL,
        category_name   VARCHAR(60) UNIQUE NOT NULL,

        PRIMARY KEY (category_id)
        );
END


IF OBJECT_ID('dbo.equipment', 'U') IS NULL
BEGIN
    CREATE TABLE equipment (
        item_id         INT IDENTITY(1001, 1) NOT NULL,
        item_name       VARCHAR(50) NOT NULL,
        category_id     INT NOT NULL,
        supplier        VARCHAR(45) NOT NULL,
        cost            DECIMAL(10, 2) NOT NULL CHECK (cost > 0),
        item_status     VARCHAR(20) NOT NULL DEFAULT 'active',
        building        VARCHAR(20) NOT NULL,
        item_desc       VARCHAR(100) NOT NULL,
        purchase_date   DATE NOT NULL CHECK (purchase_date <= GETDATE()),

        PRIMARY KEY (item_id),
        FOREIGN KEY (category_id)
            REFERENCES items_categories(category_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE
        );
END


IF OBJECT_ID('dbo.maintenance', 'U') IS NULL
BEGIN
    CREATE TABLE maintenance (
        service_id      INT IDENTITY(1101, 1) NOT NULL,
        service_type    VARCHAR(20) NOT NULL DEFAULT 'external',
        servicer        VARCHAR(50) NULL,       -- NULL = internal
        employee_id     INT NULL,               -- NOT NULL = internal
        building        VARCHAR(20) NOT NULL,
        notes           VARCHAR(100) NOT NULL,  --`equipment calibration`, `hvac system inspection`, `sensor battery replacement`, etc
        start_date      DATE NOT NULL,
        end_date        DATE NOT NULL,

        -- inline CHECK constraints may only reference the same column. therefore, some constraints have been added separately
        CONSTRAINT maintenance_end_date_chk CHECK (end_date > start_date),
        CONSTRAINT maintenance_service_logic CHECK (
            (service_type = 'internal' AND employee_id IS NOT NULL AND servicer IS NULL)
            OR
            (service_type = 'external' AND employee_id IS NULL AND servicer IS NOT NULL)
            ),

        PRIMARY KEY (service_id),
        FOREIGN KEY (employee_id)
            REFERENCES employees(employee_id)
            ON UPDATE CASCADE
            ON DELETE SET NULL  -- employee_id is already nullable, consistent with external service logic
        );
END


IF OBJECT_ID('dbo.equipment_maintenance', 'U') IS NULL
BEGIN
    CREATE TABLE equipment_maintenance (
        service_id  INT NOT NULL,
        item_id     INT NOT NULL,
        cost        DECIMAL(7, 2) NOT NULL CHECK (cost >= 0),  -- 0 is allowed for labour-only services (e.g. firmware updates, no parts needed)

        PRIMARY KEY (service_id, item_id),
        FOREIGN KEY (service_id)
            REFERENCES maintenance(service_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE,
        FOREIGN KEY (item_id)
            REFERENCES equipment(item_id)
            ON UPDATE CASCADE
            ON DELETE CASCADE
        );
END


-- frequently queried foreign keys
IF NOT EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'idx_minerals_class' 
    AND object_id = OBJECT_ID('minerals')
)
BEGIN
    CREATE INDEX idx_minerals_class ON minerals(class_id);
END


IF NOT EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'idx_minerals_country' 
    AND object_id = OBJECT_ID('minerals')
)
BEGIN
    CREATE INDEX idx_minerals_country ON minerals(country_id);
END


IF NOT EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'idx_employees_position' 
    AND object_id = OBJECT_ID('employees')
)
BEGIN
    CREATE INDEX idx_employees_position ON employees(position_id);
END


IF NOT EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'idx_transactions_customer' 
    AND object_id = OBJECT_ID('transactions')
)
BEGIN
    CREATE INDEX idx_transactions_customer ON transactions(customer_id);
END


IF NOT EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'idx_transactions_employee' 
    AND object_id = OBJECT_ID('transactions')
)
BEGIN
    CREATE INDEX idx_transactions_employee ON transactions(employee_id);
END


IF NOT EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'idx_employees_email' 
    AND object_id = OBJECT_ID('employees')
)
BEGIN
    CREATE INDEX idx_employees_email ON employees(email);
END


IF NOT EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'idx_guests_phone' 
    AND object_id = OBJECT_ID('guests')
)
BEGIN
    CREATE INDEX idx_guests_phone ON guests(phone_num);
END
