/*
- https://stackoverflow.com/questions/45060201/inserting-records-into-sql-server-how-to-update-on-conflict possibly use MERGE
- https://learn.microsoft.com/en-us/sql/relational-databases/tables/specify-computed-columns-in-a-table?view=sql-server-ver17

INSERT INTO classifications (class_name) VALUES
        ('Natives & Alloys'),
        ('Sulfides & Sulphosalts'),
        ('Halides'),
        ('Oxides & Hydroxides'),
        ('Carbonates & Borates'),
        ('Sulfates, Chromates, Molybdates & Tungstates'),
        ('Phosphates, Vanadates & Arsenates'),
        ('Silicates'),
        ('Organics')
GO

INSERT INTO sections (section_name) VALUES
        ('Atrium - Display Columns'),
        ('Atrium - Exobox'),
        ('Atrium - Large Quartz Crystal'),
        ('The 9 classes'),
        ('Radioactive minerals'),
        ('Minerals by class'),
        ('Trophies'), --38 minerals
        ('Treasure'), --21 minerals
        ('Minerals by country')
GO

INSERT INTO positions (position_title) VALUES
        ('manager'),
        ('assistant'),
        ('cashier'),
        ('security')
GO
*/

/*
application-level validation
- event status:     ('pending', 'active', 'ended', 'cancelled')
- item status:      ('active', 'in repair', 'inactive')
- session status:   ('active', 'ended')
- item location:    ('museum', 'boutique')
- donation type:    ('standard', 'event')
- service type:     ('local', 'external')
- action types:     ('create', 'update', 'delete')
*/

/*
## CHANGES
- added UNIQUE constraint to country_name

*/


CREATE TABLE classifications (
    class_id INT IDENTITY NOT NULL,
    class_name VARCHAR(50) NOT NULL,

    PRIMARY KEY (class_id)
    );


CREATE TABLE countries (
    country_id INT NOT NULL,
    country_name VARCHAR(60) UNIQUE NOT NULL,

    PRIMARY KEY (country_id)
    );


CREATE TABLE sections (
    section_id INT IDENTITY NOT NULL,
    section_name VARCHAR(30) NOT NULL,

    PRIMARY KEY (section_id)
    );


CREATE TABLE minerals (
    mineral_tag VARCHAR(12) NOT NULL,
    mineral_name VARCHAR(45) NOT NULL,
    chem_formula VARCHAR(90) NOT NULL,
    class_id INT NOT NULL,
    country_id INT NOT NULL,
    section_id INT NOT NULL,
    dimensions VARCHAR(20) NOT NULL,
    hardness_lvl INT NOT NULL CHECK (hardness_lvl BETWEEN 1 AND 10),
    mineral_desc VARCHAR(500) NOT NULL,
    is_fluorescent BIT NOT NULL DEFAULT 0,
    is_radioactive BIT NOT NULL DEFAULT 0,

    PRIMARY KEY (mineral_tag),
    FOREIGN KEY (class_id)
        REFERENCES classifications(class_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    FOREIGN KEY (country_id)
        REFERENCES countries(country_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    FOREIGN KEY (section_id)
        REFERENCES sections(section_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
    );


CREATE TABLE positions (
    position_id INT IDENTITY(201, 1) NOT NULL,
    position_title VARCHAR(20) NOT NULL,

    PRIMARY KEY (position_id)
    );


CREATE TABLE employees (
    employee_id INT IDENTITY(301, 1) NOT NULL,
    first_name VARCHAR(35) NOT NULL,
    last_name VARCHAR(45) NOT NULL,
    gender VARCHAR(6) NOT NULL CHECK (gender IN ('female', 'male')),
    date_of_birth DATE NOT NULL CHECK (date_of_birth <= DATEADD(YEAR, -18, GETDATE())),
    hire_date DATE NOT NULL CHECK (hire_date <= GETDATE()),
    email VARCHAR(50) UNIQUE NOT NULL,
    phone_num VARCHAR(17) UNIQUE NOT NULL,
    home_addr VARCHAR(150) NOT NULL,
    monthly_salary DECIMAL(7, 2) NOT NULL,
    position_id INT NOT NULL,

    PRIMARY KEY (employee_id),
    FOREIGN KEY (position_id)
        REFERENCES positions(position_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
    );


CREATE TABLE users (
    username VARCHAR(30) NOT NULL,
    password_hash VARCHAR(70) NOT NULL,
    created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME() CHECK (created_at <= SYSDATETIME()),
    last_login DATETIME2 NULL CHECK (last_login <= SYSDATETIME()), --the user might've never logged in yet
    employee_id INT NOT NULL,

    PRIMARY KEY (username),
    FOREIGN KEY (employee_id)
        REFERENCES employees(employee_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
    );


CREATE TABLE guests (
    guest_id INT IDENTITY(401, 1) NOT NULL,
    first_name VARCHAR(35) NOT NULL,
    last_name VARCHAR(45) NOT NULL,
    gender VARCHAR(6) NOT NULL CHECK (gender IN ('female', 'male')),
    email VARCHAR(50) UNIQUE NULL,
    phone_num VARCHAR(17) UNIQUE NOT NULL,

    PRIMARY KEY (guest_id)
    );


CREATE TABLE events (
    event_id INT IDENTITY(501, 1) NOT NULL,
    event_name VARCHAR(45) UNIQUE NOT NULL,
    total_guests INT NOT NULL,
    event_status VARCHAR(10) NOT NULL,
    event_date DATE NOT NULL,
    start_time TIME NOT NULL CHECK (start_time >= '08:00:00' AND start_time <= '23:00:00'),
    end_time TIME NOT NULL,

    --inline CHECK constraints may only reference the same column. therefore, some constraints have been added separately
    CONSTRAINT events_end_time_chk CHECK (end_time > start_time),
    PRIMARY KEY (event_id)
    );


CREATE TABLE events_employees (
    event_id INT NOT NULL,
    employee_id INT NOT NULL,

    FOREIGN KEY (event_id)
        REFERENCES events(event_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    FOREIGN KEY (employee_id)
        REFERENCES employees(employee_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
    );


CREATE TABLE events_attendees (
    event_id INT NOT NULL,
    guest_id INT NOT NULL,

    FOREIGN KEY (event_id)
        REFERENCES events(event_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    FOREIGN KEY (guest_id)
        REFERENCES guests(guest_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
    );


CREATE TABLE donations (
    donation_id INT IDENTITY(601, 1) NOT NULL,
    donor_id INT NULL, --NULL = anonymous
    amount DECIMAL(13, 2) NOT NULL,
    donation_type VARCHAR(20) NOT NULL DEFAULT 'standard',
    donation_date DATE NOT NULL CHECK (donation_date <= GETDATE()),
    note VARCHAR(45) NULL DEFAULT 'N/A',
    event_id INT NULL,

    PRIMARY KEY (donation_id),
    FOREIGN KEY (donor_id)
        REFERENCES guests(guest_id)
        ON UPDATE CASCADE,

    FOREIGN KEY (event_id)
        REFERENCES events(event_id)
        ON UPDATE CASCADE
    );


CREATE TABLE customers (
    customer_id INT IDENTITY(701, 1) NOT NULL,
    first_name VARCHAR(35) NOT NULL,
    last_name VARCHAR(45) NOT NULL,
    gender VARCHAR(6) NOT NULL CHECK (gender IN ('female', 'male')),
    email VARCHAR(50) UNIQUE NULL,
    phone_num VARCHAR(17) UNIQUE NOT NULL,

    PRIMARY KEY (customer_id)
	);


CREATE TABLE boutique_items (
    item_id INT IDENTITY(801, 1) NOT NULL,
    item_name VARCHAR(60) NOT NULL,
    unit_price DECIMAL(7, 2) NOT NULL,
    quantity INT NOT NULL DEFAULT 1,
    date_added DATE NOT NULL CHECK (date_added <= GETDATE()),
    ref_mineral VARCHAR(12) NULL,

    PRIMARY KEY (item_id),
    FOREIGN KEY (ref_mineral)
        REFERENCES minerals(mineral_tag)
        ON UPDATE CASCADE
        );


CREATE TABLE transactions (
    trans_uuid UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    item_id INT NOT NULL,
    customer_id INT NOT NULL,
    amount DECIMAL(7, 2) NOT NULL,
    created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME() CHECK (created_at <= SYSDATETIME()),
    employee_id INT NOT NULL,

    PRIMARY KEY (trans_uuid),
    FOREIGN KEY (item_id)
        REFERENCES boutique_items(item_id)
        ON UPDATE CASCADE,
    FOREIGN KEY (customer_id)
        REFERENCES customers(customer_id)
        ON UPDATE CASCADE,
    FOREIGN KEY (employee_id)
        REFERENCES employees(employee_id)
        ON UPDATE CASCADE
    );


CREATE TABLE items_categories (
    category_id INT IDENTITY(901, 1) NOT NULL,
    category_name VARCHAR(60) NOT NULL,

    PRIMARY KEY (category_id)
    );


CREATE TABLE equipment (
    item_id INT IDENTITY(1001, 1) NOT NULL,
    item_name VARCHAR(50) NOT NULL,
    category_id INT NOT NULL,
    supplier VARCHAR(45) NOT NULL,
    cost DECIMAL(10, 2) NOT NULL,
    item_status VARCHAR(20) NOT NULL DEFAULT 'active',
    item_location VARCHAR(8) NOT NULL,
    item_desc VARCHAR(100) NOT NULL,
    purchase_date DATE NOT NULL CHECK (purchase_date <= GETDATE()),

    PRIMARY KEY (item_id),
    FOREIGN KEY (category_id)
        REFERENCES items_categories(category_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
    );


CREATE TABLE maintenance (
    service_id INT IDENTITY(1101, 1) NOT NULL,
    service_type VARCHAR(20) NOT NULL DEFAULT 'external',
    servicer VARCHAR(50) NULL, --NULL = internal
    employee_id INT NULL, --NOT NULL = internal
    notes VARCHAR(50) NOT NULL, --`equipment calibration`, `hvac system inspection`, `sensor battery replacement`, etc
    cost DECIMAL(10, 2) NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL, 

    --inline CHECK constraints may only reference the same column. therefore, some constraints have been added separately
    CONSTRAINT maintenance_end_date_chk CHECK (end_date > start_date),

    PRIMARY KEY (service_id),
    FOREIGN KEY (employee_id)
        REFERENCES employees(employee_id)
        ON UPDATE CASCADE
    );


CREATE TABLE equipment_maintenance (
    service_id INT NOT NULL,
    item_id INT NOT NULL,
    total_cost DECIMAL(10, 2) NOT NULL,

    FOREIGN KEY (service_id)
        REFERENCES maintenance(service_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    FOREIGN KEY (item_id)
        REFERENCES equipment(item_id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
    );


CREATE TABLE audit_logs (
    action_id INT IDENTITY NOT NULL,
    action_type VARCHAR(10) NOT NULL,
    action_author VARCHAR(30) NOT NULL,
    action_msg VARCHAR(150) NOT NULL, --{user} created {user2}, {user} updated the mineral {mineral_name}
    created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME() CHECK (created_at <= SYSDATETIME()),

    PRIMARY KEY (action_id),
    FOREIGN KEY (action_author)
        REFERENCES users(username)
        ON UPDATE CASCADE
    );


CREATE TABLE login_sessions (
    session_id INT IDENTITY NOT NULL,
    username VARCHAR(30) NOT NULL,
    session_status VARCHAR(10) NOT NULL DEFAULT 'active',
    elapsed_time TIME NOT NULL,
    started_at DATETIME2 NOT NULL DEFAULT SYSDATETIME() CHECK (started_at <= SYSDATETIME()),
    ended_at DATETIME2 NOT NULL DEFAULT SYSDATETIME() CHECK (ended_at <= SYSDATETIME()),

    PRIMARY KEY (session_id),
    FOREIGN KEY (username)
        REFERENCES users(username)
        ON UPDATE CASCADE
    );
