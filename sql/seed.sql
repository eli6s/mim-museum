MERGE INTO classifications AS target
USING (
    VALUES
        ('Natives & Alloys'),
        ('Sulfides & Sulphosalts'),
        ('Halides'),
        ('Oxides & Hydroxides'),
        ('Carbonates & Borates'),
        ('Sulfates, Chromates & Tungstates'),
        ('Phosphates, Vanadates & Arsenates'),
        ('Silicates'),
        ('Organics')
    ) AS source (class_name)
ON target.class_name = source.class_name
WHEN NOT MATCHED THEN
    INSERT (class_name) VALUES (source.class_name);


MERGE INTO sections AS target
USING (
    VALUES
        ('Atrium - Display Columns'),
        ('Atrium - Exobox'),
        ('Atrium - Quartz Crystal'),
        ('The 9 Classes'),
        ('Radioactive Minerals'),
        ('Minerals by Class'),
        ('Trophies'),
        ('Treasure'),
        ('Minerals by Country')
    ) AS source (section_name)
ON target.section_name = source.section_name
WHEN NOT MATCHED THEN
    INSERT (section_name) VALUES (source.section_name);


MERGE INTO positions AS target
USING (
    VALUES
        ('manager'),
        ('assistant'),
        ('cashier')
    ) AS source (position_title)
ON target.position_title = source.position_title
WHEN NOT MATCHED THEN
    INSERT (position_title) VALUES (source.position_title);


-- COULD SAVE THIS FOR LATER TO INSERT IT DURING THE PRESENTATION
MERGE INTO employees AS target
USING (VALUES (
    'Jane', 'Doe', 'female', '2001-05-30', '2024-09-15',
    'jane.doe@mim.museum', '+96171000002', '5 Verdun Ave, Beirut',
    1200.00,
    (SELECT position_id FROM positions WHERE position_title = 'cashier')
)) AS source (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
ON target.email = source.email
WHEN NOT MATCHED THEN
    INSERT (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
    VALUES (source.first_name, source.last_name, source.gender, source.date_of_birth, source.hire_date,
            source.email, source.phone_num, source.home_addr, source.monthly_salary, source.position_id);

-- MANAGER
-- username: edoe-301
-- email: elias.doe@mim.museum

MERGE INTO employees AS target
USING (VALUES (
    'Elias', 'Doe', 'male', '2007-01-15', '2025-12-20',
    'elias.doe@mim.museum', '+96170000000', '70th Street, Beirut',
    2500.00,
    (SELECT position_id FROM positions WHERE position_title = 'manager')
)) AS source (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
ON target.email = source.email
WHEN NOT MATCHED THEN
    INSERT (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
    VALUES (source.first_name, source.last_name, source.gender, source.date_of_birth, source.hire_date,
            source.email, source.phone_num, source.home_addr, source.monthly_salary, source.position_id);

-- ASSISTANT 1
-- username: mdoe-302
-- email: mark.doe@mim.museum

MERGE INTO employees AS target
USING (VALUES (
    'Mark', 'Doe', 'male', '1998-09-14', '2024-03-01',
    'mark.doe@mim.museum', '+96171000001', '12 Hamra St, Beirut',
    1500.00,
    (SELECT position_id FROM positions WHERE position_title = 'assistant')
)) AS source (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
ON target.email = source.email
WHEN NOT MATCHED THEN
    INSERT (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
    VALUES (source.first_name, source.last_name, source.gender, source.date_of_birth, source.hire_date,
            source.email, source.phone_num, source.home_addr, source.monthly_salary, source.position_id);

-- CASHIER 1
-- username: jdoe-303
-- email: john.doe@mim.museum

MERGE INTO employees AS target
USING (VALUES (
    'John', 'Doe', 'male', '2004-02-15', '2022-06-03',
    'john.doe@mim.museum', '+96171000003', '7 Hamra St, Beirut',
    1200.00,
    (SELECT position_id FROM positions WHERE position_title = 'cashier')
)) AS source (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
ON target.email = source.email
WHEN NOT MATCHED THEN
    INSERT (first_name, last_name, gender, date_of_birth, hire_date, email, phone_num, home_addr, monthly_salary, position_id)
    VALUES (source.first_name, source.last_name, source.gender, source.date_of_birth, source.hire_date,
            source.email, source.phone_num, source.home_addr, source.monthly_salary, source.position_id);


IF NOT EXISTS (SELECT 1 FROM users u JOIN employees e ON u.employee_id = e.employee_id WHERE e.email = 'elias.doe@mim.museum')
BEGIN
    DECLARE @emp1 INT = (SELECT employee_id FROM employees WHERE email = 'elias.doe@mim.museum');
    INSERT INTO users (username, password_hash, employee_id)
    VALUES ('edoe-' + CAST(@emp1 AS VARCHAR(10)), '$2a$11$v8Yss2Jpgb.Ufoxj48eXLe4NPVWr30NCzsgC3/5OV8472G/sbnHd.', @emp1);
END

IF NOT EXISTS (SELECT 1 FROM users u JOIN employees e ON u.employee_id = e.employee_id WHERE e.email = 'mark.doe@mim.museum')
BEGIN
    DECLARE @emp2 INT = (SELECT employee_id FROM employees WHERE email = 'mark.doe@mim.museum');
    INSERT INTO users (username, password_hash, employee_id)
    VALUES ('mdoe-' + CAST(@emp2 AS VARCHAR(10)), '$2a$11$v8Yss2Jpgb.Ufoxj48eXLe4NPVWr30NCzsgC3/5OV8472G/sbnHd.', @emp2);
END

IF NOT EXISTS (SELECT 1 FROM users u JOIN employees e ON u.employee_id = e.employee_id WHERE e.email = 'john.doe@mim.museum')
BEGIN
    DECLARE @emp3 INT = (SELECT employee_id FROM employees WHERE email = 'john.doe@mim.museum');
    INSERT INTO users (username, password_hash, employee_id)
    VALUES ('jdoe-' + CAST(@emp3 AS VARCHAR(10)), '$2a$11$v8Yss2Jpgb.Ufoxj48eXLe4NPVWr30NCzsgC3/5OV8472G/sbnHd.', @emp3);
END


IF NOT EXISTS (SELECT 1 FROM minerals WHERE mineral_tag = 'mim 354')
INSERT INTO minerals (mineral_tag, mineral_name, chem_formula, class_id, country_id, section_id, dimensions, hardness_lvl, mineral_desc, is_fluorescent, is_radioactive) VALUES

-- THE 9 CLASSES
('mim 354',  'Copper',
    'Cu',
    (SELECT class_id FROM classifications WHERE class_name = 'Natives & Alloys'),
    (SELECT country_id FROM countries WHERE country_name = 'United States'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '21 x 15 x 14 cm', 3,
    'Three-dimensional aggregate of crystals showing tetrahexahedral faces in an unusual oscillatory growth.',
    0, 0),

('mim 1109', 'Stibnite',
    'Sb2S3',
    (SELECT class_id FROM classifications WHERE class_name = 'Sulfides & Sulphosalts'),
    (SELECT country_id FROM countries WHERE country_name = 'China'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '43 x 38 x 50 cm', 2,
    'Bush of elongated, brilliant and very well terminated crystals.',
    0, 0),

('mim 2102', 'Fluorite',
    'CaF2',
    (SELECT class_id FROM classifications WHERE class_name = 'Halides'),
    (SELECT country_id FROM countries WHERE country_name = 'Switzerland'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '32 x 42 x 26 cm', 4,
    'Huge translucent pink fluorite octahedron on a leached granite slab. Displays a phantom and is one of the biggest pink fluorites from the Alps.',
    0, 0),

('mim 1106', 'Hematite',
    'Fe2O3',
    (SELECT class_id FROM classifications WHERE class_name = 'Oxides & Hydroxides'),
    (SELECT country_id FROM countries WHERE country_name = 'South Africa'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '20 x 18.5 x 8 cm', 7,
    'Sheet of perfect crystals with very lustrous faces, with micro-crystallized hausmannite and white barite.',
    0, 0),

('mim 2185', 'Malachite',
    'Cu2(CO3)(OH)2',
    (SELECT class_id FROM classifications WHERE class_name = 'Carbonates & Borates'),
    (SELECT country_id FROM countries WHERE country_name = 'Congo'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '40 x 26 x 68 cm', 4,
    'Nicknamed "Emerald City". Large parallel stalactites of shiny green malachite on earthy matrix, giving a wet look under lighting.',
    0, 0),

('mim 753',  'Baryte',
    'BaSO4',
    (SELECT class_id FROM classifications WHERE class_name = 'Sulfates, Chromates & Tungstates'),
    (SELECT country_id FROM countries WHERE country_name = 'United States'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '28 x 25 x 11 cm', 3,
    'Large, intact sheet of transparent amber-colored barite tablets interspersed with lenticular white calcite crystals.',
    0, 0),

('mim 345',  'Vanadinite',
    'Pb5(VO4)3Cl',
    (SELECT class_id FROM classifications WHERE class_name = 'Phosphates, Vanadates & Arsenates'),
    (SELECT country_id FROM countries WHERE country_name = 'Morocco'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '25.5 x 25 x 13 cm', 3,
    'Rock covered with white barite and black pyrolusite, coated with dark red tabular crystals of vanadinite.',
    0, 0),

('mim 2228', 'Beryl (var. Aquamarine)',
    'Be3Al2Si6O18',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Pakistan'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '40 x 25 x 30 cm', 8,
    'Long, slender transparent blue aquamarine crystal on a complex matrix containing topaz, quartz, feldspar, arsenopyrite, and rhodochrosite.',
    0, 0),

('mim 1161', 'Whewellite',
    'Ca(C2O4).H2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Organics'),
    (SELECT country_id FROM countries WHERE country_name = 'Russia'),
    (SELECT section_id FROM sections WHERE section_name = 'The 9 Classes'),
    '9.5 x 4 x 5.5 cm', 3,
    'Perfect, transparent and colorless V-shaped twinned crystal, one branch partially buried in gray matrix.',
    0, 0),

-- ATRIUM: LARGE QUARTZ CRYSTAL
('mim 1260', 'Quartz',
    'SiO2',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Brazil'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Quartz Crystal'),
    '27 x 26 x 77 cm', 7,
    'Large transparent crystal with milky base, well terminated and garnished with cleavelandite blades. Very little scarring for its size.',
    0, 0),

-- ATRIUM: EXOBOX
('mim 199',  'Beryl (Aquamarine)',
    'Be3Al2Si6O18',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Pakistan'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Exobox'),
    '11.5 x 11 x 8.5 cm', 8,
    'Well-formed milky blue hexagonal crystals on mica with a translucent pink apatite crystal (3 cm).',
    0, 0),

('mim 667',  'Crocoite',
    'PbCrO4',
    (SELECT class_id FROM classifications WHERE class_name = 'Sulfates, Chromates & Tungstates'),
    (SELECT country_id FROM countries WHERE country_name = 'Australia'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Exobox'),
    '12 x 8.5 x 7 cm', 3,
    'Lustrous orange-red stout and sharp crystals in a limonite geode. Unusual crystal habit for this locality.',
    0, 0),

('mim 1805', 'Baryte',
    'BaSO4',
    (SELECT class_id FROM classifications WHERE class_name = 'Sulfates, Chromates & Tungstates'),
    (SELECT country_id FROM countries WHERE country_name = 'Germany'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Exobox'),
    '9 x 14 x 6.5 cm', 3,
    'Group of golden barite crystals with transparent terminations developed on a microcrystalline quartz matrix.',
    0, 0),

-- ATRIUM: DISPLAY COLUMNS
('mim 1835', 'Malachite',
    'Cu2(CO3)(OH)2',
    (SELECT class_id FROM classifications WHERE class_name = 'Carbonates & Borates'),
    (SELECT country_id FROM countries WHERE country_name = 'China'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Display Columns'),
    '7.3 x 10 x 23 cm', 4,
    'Large malachite specimen displayed in the atrium column cases.',
    0, 0),

('mim 1952', 'Halite',
    'NaCl',
    (SELECT class_id FROM classifications WHERE class_name = 'Halides'),
    (SELECT country_id FROM countries WHERE country_name = 'Germany'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Display Columns'),
    '28 x 18 x 25 cm', 3,
    'Well formed halite crystals with cubic and tabular shapes intermingled with fishtail twinned gypsum crystals. Very fluorescent under short UV rays; gypsum crystals also phosphorescent.',
    1, 0),

('mim 1032', 'Baryte',
    'BaSO4',
    (SELECT class_id FROM classifications WHERE class_name = 'Sulfates, Chromates & Tungstates'),
    (SELECT country_id FROM countries WHERE country_name = 'China'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Display Columns'),
    '28.5 x 24.5 x 16.5 cm', 3,
    'Thick, lustrous, translucent gray-blue crystals developed on stibnite needles with granular yellow calcite.',
    0, 0),

('mim 1727', 'Elbaite',
    'Na(Li,Al)3Al6(BO3)3Si6O18(OH)4',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Brazil'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Display Columns'),
    '3.5 x 2.2 x 14 cm', 7,
    'Multicolored elbaite tourmaline specimen displayed in the atrium column cases.',
    0, 0),

('mim 2283', 'Azurite',
    'Cu3(CO3)2(OH)2',
    (SELECT class_id FROM classifications WHERE class_name = 'Carbonates & Borates'),
    (SELECT country_id FROM countries WHERE country_name = 'Mexico'),
    (SELECT section_id FROM sections WHERE section_name = 'Atrium - Display Columns'),
    '15 x 9 x 12 cm', 4,
    'Azurite specimen displayed in the atrium column cases.',
    0, 0),

-- TROPHIES
('mim 958',  'Legrandite',
    'Zn2(AsO4)(OH).H2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Phosphates, Vanadates & Arsenates'),
    (SELECT country_id FROM countries WHERE country_name = 'Mexico'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '13.5 x 10.5 x 19 cm', 4,
    'Known as the "Aztec Sun". Large sheaf of very lustrous yellow crystals in a V-shape, with micro-crystallized scorodite and traces of limonite at the top. One of the most beautiful specimens recovered from this exceptional find.',
    0, 0),

('mim 2390', 'Rhodochrosite',
    'MnCO3',
    (SELECT class_id FROM classifications WHERE class_name = 'Carbonates & Borates'),
    (SELECT country_id FROM countries WHERE country_name = 'South Africa'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '7.3 x 18 x 3 cm', 4,
    'Bright pink rhombohedral crystals, highly lustrous and of exceptional color, among the finest from N''Chwaning.',
    0, 0),

('mim 1533', 'Apatite',
    'Ca5(PO4)3(F,Cl,OH)',
    (SELECT class_id FROM classifications WHERE class_name = 'Phosphates, Vanadates & Arsenates'),
    (SELECT country_id FROM countries WHERE country_name = 'Portugal'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '21 x 6 x 12 cm', 5,
    'Transparent hexagonal phosphate crystals, typically bluish-green, showing excellent clarity and symmetry.',
    0, 0),

('mim 840',  'Azurite',
    'Cu3(CO3)2(OH)2',
    (SELECT class_id FROM classifications WHERE class_name = 'Carbonates & Borates'),
    (SELECT country_id FROM countries WHERE country_name = 'Namibia'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '21 x 7 x 14 cm', 4,
    'Deep blue prismatic azurite crystals. Outstanding color saturation and luster.',
    0, 0),

('mim 771',  'Elbaite (Tourmaline)',
    'Na(Li1.5Al1.5)Al6(BO3)3Si6O18(OH)4',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Afghanistan'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '21 x 6 x 12 cm', 7,
    'Multicolored lithium-rich tourmaline showing pink-to-green zoning, from pegmatites of Afghanistan.',
    0, 0),

('mim 346',  'Pyrite',
    'FeS2',
    (SELECT class_id FROM classifications WHERE class_name = 'Sulfides & Sulphosalts'),
    (SELECT country_id FROM countries WHERE country_name = 'Peru'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '11 x 3 x 12 cm', 6,
    'Large, well-formed cubic pyrite crystals showing sharp edges and metallic brilliance.',
    0, 0),

('mim 1130', 'Rutile',
    'TiO2',
    (SELECT class_id FROM classifications WHERE class_name = 'Oxides & Hydroxides'),
    (SELECT country_id FROM countries WHERE country_name = 'Brazil'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '9 x 13 x 8 cm', 6,
    'Radiating acicular rutile crystals with metallic luster, typically found in quartz veins.',
    0, 0),

('mim 1359', 'Fluorite',
    'CaF2',
    (SELECT class_id FROM classifications WHERE class_name = 'Halides'),
    (SELECT country_id FROM countries WHERE country_name = 'Pakistan'),
    (SELECT section_id FROM sections WHERE section_name = 'Trophies'),
    '8.5 x 8 x 12 cm', 4,
    'Transparent, color-zoned cubic fluorite crystals with quartz and calcite. Beautiful clarity and symmetry.',
    0, 0),

-- TREASURE
('mim 432',  'Elbaite (Rubellite)',
    'Na(Li,Al)3Al6(BO3)3Si6O18(OH)4',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Brazil'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '5 x 3 x 13 cm', 7,
    'Two transparent, doubly terminated V-shaped crystals with classic rubellite color.',
    0, 0),

('mim 1261', 'Beryl (Heliodor)',
    'Be3Al2Si6O18',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Russia'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '3 x 2.5 x 12.5 cm', 8,
    'Transparent hexagonal yellow-amber crystal with light surface corrosion and excellent termination.',
    0, 0),

('mim 1591', 'Diamond',
    'C',
    (SELECT class_id FROM classifications WHERE class_name = 'Natives & Alloys'),
    (SELECT country_id FROM countries WHERE country_name = 'Russia'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '2.5 x 1.9 x 1.9 cm', 10,
    '53.05-ct octahedron with smooth faces and central sulfide inclusions creating kaleidoscope reflections.',
    0, 0),

('mim 2199', 'Diamond',
    'C',
    (SELECT class_id FROM classifications WHERE class_name = 'Natives & Alloys'),
    (SELECT country_id FROM countries WHERE country_name = 'South Africa'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '3 x 3 x 3 cm', 10,
    '92.58-ct light yellow, perfectly formed octahedron, extremely clean with one tiny inclusion.',
    0, 0),

('mim 1550', 'Diamond',
    'C',
    (SELECT class_id FROM classifications WHERE class_name = 'Natives & Alloys'),
    (SELECT country_id FROM countries WHERE country_name = 'Angola'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '1.5 x 1.5 x 1.5 cm', 10,
    'Pale yellow clean 33.38-ct octahedron showing M-shaped growth figures.',
    0, 0),

('mim 761',  'Gold',
    'Au',
    (SELECT class_id FROM classifications WHERE class_name = 'Natives & Alloys'),
    (SELECT country_id FROM countries WHERE country_name = 'United States'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '7.5 x 6.5 x 11 cm', 3,
    'Very shiny polyhedral crystals on white quartz; a well-terminated quartz crystal is partially trapped in the gold.',
    0, 0),

('mim 794',  'Gold',
    'Au',
    (SELECT class_id FROM classifications WHERE class_name = 'Natives & Alloys'),
    (SELECT country_id FROM countries WHERE country_name = 'United States'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '13 x 8 x 9 cm', 3,
    'Nicknamed "The Bonsai". Bonsai-shaped cluster of lustrous, sharp-edged, complex shaped gold crystals on matrix.',
    0, 0),

('mim 1360', 'Silver',
    'Ag',
    (SELECT class_id FROM classifications WHERE class_name = 'Natives & Alloys'),
    (SELECT country_id FROM countries WHERE country_name = 'Norway'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '10 x 4 x 15 cm', 3,
    'Thick thread of silver bent several times, encrusted with small white calcite rhombohedrons.',
    0, 0),

('mim 1100', 'Topaz',
    'Al2SiO4(F,OH)2',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Brazil'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '18 x 14 x 17 cm', 8,
    'Large transparent blue crystal with sharp bevels and iridescent trapped fluid layer.',
    0, 0),

('mim 1028', 'Rhodochrosite',
    'MnCO3',
    (SELECT class_id FROM classifications WHERE class_name = 'Carbonates & Borates'),
    (SELECT country_id FROM countries WHERE country_name = 'United States'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '17.5 x 14 x 7 cm', 4,
    'Two large transparent red crystals on lustrous black tetrahedrite matrix; among finest from this mine.',
    0, 0),

('mim 1313', 'Zoisite (var. Tanzanite)',
    'Ca2Al3(SiO4)3(OH)',
    (SELECT class_id FROM classifications WHERE class_name = 'Silicates'),
    (SELECT country_id FROM countries WHERE country_name = 'Tanzania'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '3.5 x 5.5 x 14.5 cm', 7,
    'Lustrous, very transparent single crystal with few inclusions and marked trichroism. Some graphite at the base, characteristic of the Merelani mine.',
    0, 0),

('mim 1707', 'Opal (var. Black Opal)',
    'SiO2.nH2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Oxides & Hydroxides'),
    (SELECT country_id FROM countries WHERE country_name = 'Australia'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '4 x 3 x 1 cm', 6,
    '55.72-ct elongated oval stone with a flat opalized surface and a central Y-shaped pattern with strong red/crimson play of colors. Color changes with light and angle.',
    0, 0),

('mim 1661', 'Opal (var. Black Opal)',
    'SiO2.nH2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Oxides & Hydroxides'),
    (SELECT country_id FROM countries WHERE country_name = 'Australia'),
    (SELECT section_id FROM sections WHERE section_name = 'Treasure'),
    '7.5 x 6 x 1 cm', 6,
    'Slab of black precious opal (254 carats) with green, dark blue, and hits of orange/gold, reminiscent of peacock feathers.',
    0, 0),

-- RADIOACTIVE MINERALS
('mim 1310', 'Torbernite',
    'Cu(UO2)2(PO4)2.8-12H2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Phosphates, Vanadates & Arsenates'),
    (SELECT country_id FROM countries WHERE country_name = 'Congo'),
    (SELECT section_id FROM sections WHERE section_name = 'Radioactive Minerals'),
    '10 x 7.5 x 5.5 cm', 2,
    'Dome of tabular, emerald green and very sharp-edged crystals; well separated, reinforcing the three-dimensional aspect of the piece.',
    0, 1),

('mim 1986', 'Torbernite',
    'Cu(UO2)2(PO4)2.8-12H2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Phosphates, Vanadates & Arsenates'),
    (SELECT country_id FROM countries WHERE country_name = 'Congo'),
    (SELECT section_id FROM sections WHERE section_name = 'Radioactive Minerals'),
    '17 x 12 x 26 cm', 2,
    'Sugar loaf shaped mound covered with tufts of lustrous, emerald-green torbernite tabular crystals.',
    0, 1),

('mim 238',  'Torbernite',
    'Cu(UO2)2(PO4)2.8-12H2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Phosphates, Vanadates & Arsenates'),
    (SELECT country_id FROM countries WHERE country_name = 'Congo'),
    (SELECT section_id FROM sections WHERE section_name = 'Radioactive Minerals'),
    '17 x 9 x 7 cm', 2,
    'Translucent blades of a beautiful emerald green in thick books on a black matrix. Typical of the finest specimens from this mine.',
    0, 1),

('mim 1546', 'Autunite (var. Meta-autunite)',
    'Ca(UO2)2(PO4)2.10-12H2O',
    (SELECT class_id FROM classifications WHERE class_name = 'Phosphates, Vanadates & Arsenates'),
    (SELECT country_id FROM countries WHERE country_name = 'United States'),
    (SELECT section_id FROM sections WHERE section_name = 'Radioactive Minerals'),
    '17 x 12.5 x 8 cm', 2,
    'Intact block covered with thick tufts of dark green lamellar crystals. Strong green fluorescence under UV light.',
    1, 1);


IF NOT EXISTS (SELECT 1 FROM items_categories WHERE category_name = 'Interactive Display')
INSERT INTO items_categories (category_name) VALUES
('Interactive Display'),
('3D Holographic Display'),
('Projector'),
('Software'),
('PTZ Camera'),
('Digital Camera'),
('LED Spotlight'),
('UV Lighting'),
('Environmental Control'),
('Environmental Sensor'),
('Display Case'),
('Security Camera'),
('Access Control'),
('Fire & Safety'),
('Audio Guide'),
('Sound System'),
('Fabrication'),
('Retail Equipment'),
('Display Stand');


-- 9. EQUIPMENT

IF NOT EXISTS (SELECT 1 FROM equipment WHERE item_name = 'Microsoft Surface Hub 2S')
INSERT INTO equipment (item_name, category_id, supplier, cost, item_status, building, item_desc, purchase_date) VALUES
('Microsoft Surface Hub 2S',
    (SELECT category_id FROM items_categories WHERE category_name = 'Interactive Display'),
    'Microsoft', 4500.00, 'active', 'museum',
    'Large interactive touchscreen kiosk for the periodic table, mineral pages, and zoomable imagery.',
    '2023-06-01'),

('Realfiction Dreamoc HD3',
    (SELECT category_id FROM items_categories WHERE category_name = '3D Holographic Display'),
    'Realfiction', 18000.00, 'active', 'museum',
    'Glass/box holographic display; specimen sits inside and 3D image appears projected in front.',
    '2023-06-01'),

('Samsung Flip 2 (WM55R)',
    (SELECT category_id FROM items_categories WHERE category_name = 'Interactive Display'),
    'Samsung', 2200.00, 'active', 'museum',
    '55" touch display for zoomable, high-resolution images with multi-touch pinch/zoom.',
    '2023-07-15'),

('Artec Eva 3D Scanner',
    (SELECT category_id FROM items_categories WHERE category_name = 'Digital Camera'),
    'Artec', 18000.00, 'active', 'museum',
    'Portable structured-light 3D scanner for capturing high-detail scans of mineral specimens.',
    '2023-06-01'),

('Epson Pro L1495U Laser Projector',
    (SELECT category_id FROM items_categories WHERE category_name = 'Projector'),
    'Epson', 25000.00, 'active', 'museum',
    'High-brightness laser projector for projection-mapped videos and large-format displays.',
    '2023-08-01'),

('Ventuz Production Suite (license)',
    (SELECT category_id FROM items_categories WHERE category_name = 'Software'),
    'Ventuz', 6000.00, 'active', 'museum',
    'Real-time rendering and projection-mapping software for immersive interactive content.',
    '2023-08-01'),

('Vaddio RoboSHOT 12HD PTZ Camera',
    (SELECT category_id FROM items_categories WHERE category_name = 'PTZ Camera'),
    'Vaddio', 2200.00, 'active', 'museum',
    'PTZ camera to capture live close-ups of specimens for zoomable streams on displays.',
    '2023-09-01'),

('Canon EOS 5D Mark IV',
    (SELECT category_id FROM items_categories WHERE category_name = 'Digital Camera'),
    'Canon', 2500.00, 'active', 'museum',
    'High-resolution DSLR for cataloging specimens and producing display content.',
    '2023-06-01'),

('Philips LEDspot MV (12W)',
    (SELECT category_id FROM items_categories WHERE category_name = 'LED Spotlight'),
    'Philips', 120.00, 'active', 'museum',
    'Accent LED spotlight with dimming for specimen illumination without excess heat or UV.',
    '2023-06-01'),

('Philips F40BLB Blacklight UV-A',
    (SELECT category_id FROM items_categories WHERE category_name = 'UV Lighting'),
    'Philips', 60.00, 'active', 'museum',
    'UV-A blacklight tube for controlled fluorescent-mineral viewing in shielded enclosures.',
    '2023-06-01'),

('Daikin VRV IV Commercial HVAC',
    (SELECT category_id FROM items_categories WHERE category_name = 'Environmental Control'),
    'Daikin', 45000.00, 'active', 'museum',
    'Commercial HVAC/VRV system for full gallery climate control, temperature and humidity.',
    '2023-04-01'),

('Onset HOBO UX120-011 Data Logger',
    (SELECT category_id FROM items_categories WHERE category_name = 'Environmental Sensor'),
    'Onset', 230.00, 'active', 'museum',
    'Temperature and RH data logger for monitoring microclimates in display cases.',
    '2023-06-01'),

('MDS-CC1 Climate Display Case',
    (SELECT category_id FROM items_categories WHERE category_name = 'Display Case'),
    'Museum Display Services', 4500.00, 'active', 'museum',
    'Custom climate-controlled glass display case with RH control and sealed glazing.',
    '2023-05-01'),

('Axis P3225-LVE Network Camera',
    (SELECT category_id FROM items_categories WHERE category_name = 'Security Camera'),
    'Axis Communications', 900.00, 'active', 'museum',
    'Indoor/outdoor network camera for continuous surveillance of galleries.',
    '2023-06-01'),

('HID Signo 20 RFID Reader',
    (SELECT category_id FROM items_categories WHERE category_name = 'Access Control'),
    'HID', 1100.00, 'active', 'museum',
    'RFID reader for restricted-area access to conservation and storage rooms.',
    '2023-06-01'),

('Netatmo Smart Smoke Alarm System',
    (SELECT category_id FROM items_categories WHERE category_name = 'Fire & Safety'),
    'Netatmo / Bosch', 600.00, 'active', 'museum',
    'Networked smoke and CO detection integrated with the building alarm panel.',
    '2023-06-01'),

('ListenTALK LT-800 Audio Guide',
    (SELECT category_id FROM items_categories WHERE category_name = 'Audio Guide'),
    'Listen Technologies', 160.00, 'active', 'museum',
    'Multichannel tour-guide audio unit for on-floor narrated guides.',
    '2023-09-01'),

('Bose FreeSpace FS2C Ceiling Speaker',
    (SELECT category_id FROM items_categories WHERE category_name = 'Sound System'),
    'Bose', 380.00, 'active', 'museum',
    'Distributed ceiling speaker for ambient audio and exhibit narration zones.',
    '2023-06-01'),

('Epilog Zing 24 Laser Engraver',
    (SELECT category_id FROM items_categories WHERE category_name = 'Fabrication'),
    'Epilog', 8000.00, 'active', 'museum',
    'Small laser engraver for creating durable specimen labels and signage.',
    '2023-07-01'),

('Epson TM-T88VI Receipt Printer',
    (SELECT category_id FROM items_categories WHERE category_name = 'Retail Equipment'),
    'Epson', 300.00, 'active', 'boutique',
    'Thermal receipt printer for printing sales receipts.',
    '2023-09-15'),

('APG Vasario 1616 Cash Drawer',
    (SELECT category_id FROM items_categories WHERE category_name = 'Retail Equipment'),
    'APG', 150.00, 'active', 'boutique',
    'Heavy-duty cash drawer for secure cash and coin storage.',
    '2023-09-15'),

('Square Reader (Contactless/Chip)',
    (SELECT category_id FROM items_categories WHERE category_name = 'Retail Equipment'),
    'Square', 50.00, 'active', 'boutique',
    'Portable card reader for processing contactless and chip payments.',
    '2023-09-15'),

('Displays2Go Slatwall Display Stand',
    (SELECT category_id FROM items_categories WHERE category_name = 'Display Stand'),
    'Displays2Go', 200.00, 'active', 'boutique',
    'Adjustable slatwall display stand for showcasing boutique merchandise.',
    '2023-09-15'),

('Wyze Cam v3',
    (SELECT category_id FROM items_categories WHERE category_name = 'Security Camera'),
    'Wyze', 35.00, 'active', 'boutique',
    'Indoor security camera with motion detection, night vision, and cloud storage.',
    '2023-09-15');


-- 10. MAINTENANCE + EQUIPMENT_MAINTENANCE
-- end_date must be > start_date (constraint). Single-day jobs use +1 day.

-- service 1: HVAC pre-summer (external)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'HVAC pre-summer service: filter replacement, refrigerant check, coil cleaning.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('external', 'Daikin Service Partner', NULL,
            'museum',
            'HVAC pre-summer service: filter replacement, refrigerant check, coil cleaning.',
            '2024-05-10', '2024-05-12');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Daikin VRV IV Commercial HVAC'), 1200.00);
END

-- service 2: HVAC pre-winter (external)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'HVAC pre-winter check: thermostat calibration, duct inspection.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('external', 'Daikin Service Partner', NULL,
            'museum',
            'HVAC pre-winter check: thermostat calibration, duct inspection.',
            '2024-10-20', '2024-10-21');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Daikin VRV IV Commercial HVAC'), 800.00);
END

-- service 3: Surface Hub annual calibration (external)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'Annual touch-screen calibration and software update for Surface Hub units.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('external', 'Microsoft Certified Technician', NULL,
            'museum',
            'Annual touch-screen calibration and software update for Surface Hub units.',
            '2024-03-15', '2024-03-16');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Microsoft Surface Hub 2S'), 350.00);
END

-- service 4: HOBO logger battery replacement (internal — Youssef)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'Batch battery replacement and data download for HOBO loggers.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('internal', NULL,
            (SELECT employee_id FROM employees WHERE email = 'mark.doe@mim.museum'),
            'museum',
            'Batch battery replacement and data download for HOBO loggers.',
            '2024-04-01', '2024-04-02');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Onset HOBO UX120-011 Data Logger'), 120.00);
END

-- service 5: UV bulb replacement (internal — Youssef)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'Two UV-A blacklight tubes replaced after lumen degradation below threshold.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('internal', NULL,
            (SELECT employee_id FROM employees WHERE email = 'mark.doe@mim.museum'),
            'museum',
            'Two UV-A blacklight tubes replaced after lumen degradation below threshold.',
            '2024-06-18', '2024-06-19');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Philips F40BLB Blacklight UV-A'), 80.00);
END

-- service 6: Laser projector lens cleaning (external)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'Laser projector lens cleaning and hours log review. 4,200 hrs — within spec.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('external', 'Epson Service Partner', NULL,
            'museum',
            'Laser projector lens cleaning and hours log review. 4,200 hrs — within spec.',
            '2024-07-05', '2024-07-06');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Epson Pro L1495U Laser Projector'), 200.00);
END

-- service 7: Security camera firmware update (internal — Elias)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'Firmware update pushed to all Axis cameras; image quality audit completed.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('internal', NULL,
            (SELECT employee_id FROM employees WHERE email = 'elias.doe@mim.museum'),
            'museum',
            'Firmware update pushed to all Axis cameras; image quality audit completed.',
            '2024-09-10', '2024-09-11');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    -- i think a conflict is occuring because the cost is 0 and it's NOT supposed to be 0. should internal maintenance services
    -- cost 0?
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Axis P3225-LVE Network Camera'), 0.00);
END

-- service 8: Laser engraver lens and belt (external)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'Epilog Zing lens cleaning, belt tension check, and worn focus probe replacement.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('external', 'Epilog Technician', NULL,
            'museum',
            'Epilog Zing lens cleaning, belt tension check, and worn focus probe replacement.',
            '2024-08-22', '2024-08-23');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Epilog Zing 24 Laser Engraver'), 95.00);
END

-- service 9: Dreamoc cleaning (internal — Youssef)
IF NOT EXISTS (SELECT 1 FROM maintenance WHERE notes = 'Interior glass cleaning and LED driver inspection on all Dreamoc units.')
BEGIN
    INSERT INTO maintenance (service_type, servicer, employee_id, building, notes, start_date, end_date)
    VALUES ('internal', NULL,
            (SELECT employee_id FROM employees WHERE email = 'mark.doe@mim.museum'),
            'museum',
            'Interior glass cleaning and LED driver inspection on all Dreamoc units.',
            '2024-11-05', '2024-11-06');
    INSERT INTO equipment_maintenance (service_id, item_id, cost)
    VALUES (SCOPE_IDENTITY(), (SELECT item_id FROM equipment WHERE item_name = 'Realfiction Dreamoc HD3'), 150.00);
END


-- 11. GUESTS  (events & donations — separate from boutique customers)

IF NOT EXISTS (SELECT 1 FROM guests WHERE phone_num = '+96170200001')
INSERT INTO guests (first_name, last_name, gender, email, phone_num) VALUES
('Rania',  'Khalil',     'female', 'rania.khalil@aub.edu.lb',  '+96170200001'),
('Nabil',  'Saab',       'male',   'nabil@nabilsaab.org',       '+96170200002'),
('Hadi',   'Frem',       'male',   'hadi.frem@email.com',       '+96170200003'),
('Tania',  'Ghandour',   'female', 'tania.ghandour@email.com',  '+96170200004'),
('Samir',  'Kassir',     'male',   'samir@fondation-sk.org',    '+96170200005'),
('Dina',   'Rahhal',     'female', 'dina.rahhal@email.com',     '+96170200006'),
('Faris',  'Abou Mrad',  'male',   'faris.aboumrad@email.com',  '+96170200007'),
('Lina',   'Traboulsi',  'female', 'lina.traboulsi@email.com',  '+96170200008'),
('Ziad',   'Nakad',      'male',   'ziad.nakad@email.com',      '+96170200009'),
('Maya',   'Abi Nader',  'female', 'maya.abinader@email.com',   '+96170200010');


-- 12. EVENTS

IF NOT EXISTS (SELECT 1 FROM events WHERE event_name = 'Museum Opening Night')
INSERT INTO events (event_name, total_guests, event_status, event_date, start_time, end_time) VALUES
('Museum Opening Night',         142, 'completed', '2024-01-15', '18:00', '22:00'),
('Minerals of the Earth Talk',    74, 'completed', '2024-02-20', '17:00', '19:00'),
('School Tour - College ND',      62, 'completed', '2024-03-12', '09:00', '12:00'),
('Gem & Mineral Fair',           278, 'completed', '2024-04-06', '10:00', '18:00'),
('Photography Workshop',          15, 'completed', '2024-05-25', '10:00', '14:00'),
('Summer Family Day',            387, 'completed', '2024-07-20', '10:00', '17:00'),
('Fluorescent Minerals Night',    40, 'completed', '2024-09-14', '19:00', '21:30'),
('Radioactive Minerals Seminar',  48, 'completed', '2024-10-08', '16:00', '18:30'),
('Holiday Boutique Evening',      67, 'completed', '2024-12-14', '17:00', '20:00'),
('Treasure Vault Preview',        28, 'completed', '2025-01-25', '11:00', '13:00'),
('Geology for Kids Workshop',     22, 'completed', '2025-03-08', '10:00', '12:00'),
('Annual Gala & Donor Reception',  0, 'upcoming',  '2026-07-15', '19:00', '23:00');


-- events_employees

IF NOT EXISTS (SELECT 1 FROM events_employees)
INSERT INTO events_employees (event_id, employee_id)
SELECT e.event_id, emp.employee_id
FROM (VALUES
    ('Museum Opening Night',          'elias.doe@mim.museum'),
    ('Museum Opening Night',          'mark.doe@mim.museum'),
    ('Minerals of the Earth Talk',    'mark.doe@mim.museum'),
    ('School Tour - College ND',      'mark.doe@mim.museum'),
    ('Gem & Mineral Fair',            'elias.doe@mim.museum'),
    ('Gem & Mineral Fair',            'john.doe@mim.museum'),
    ('Photography Workshop',          'mark.doe@mim.museum'),
    ('Summer Family Day',             'elias.doe@mim.museum'),
    ('Summer Family Day',             'mark.doe@mim.museum'),
    ('Summer Family Day',             'john.doe@mim.museum'),
    ('Fluorescent Minerals Night',    'mark.doe@mim.museum'),
    ('Radioactive Minerals Seminar',  'elias.doe@mim.museum'),
    ('Holiday Boutique Evening',      'john.doe@mim.museum'),
    ('Treasure Vault Preview',        'elias.doe@mim.museum'),
    ('Geology for Kids Workshop',     'mark.doe@mim.museum'),
    ('Annual Gala & Donor Reception', 'elias.doe@mim.museum'),
    ('Annual Gala & Donor Reception', 'mark.doe@mim.museum')
) AS v(event_name, email)
JOIN events    e   ON e.event_name  = v.event_name
JOIN employees emp ON emp.email     = v.email;


-- events_attendees

IF NOT EXISTS (SELECT 1 FROM events_attendees)
INSERT INTO events_attendees (event_id, guest_id)
SELECT e.event_id, g.guest_id
FROM (VALUES
    ('Museum Opening Night',          '+96170200001'),
    ('Museum Opening Night',          '+96170200002'),
    ('Museum Opening Night',          '+96170200003'),
    ('Museum Opening Night',          '+96170200005'),
    ('Minerals of the Earth Talk',    '+96170200001'),
    ('Minerals of the Earth Talk',    '+96170200006'),
    ('Gem & Mineral Fair',            '+96170200003'),
    ('Gem & Mineral Fair',            '+96170200007'),
    ('Gem & Mineral Fair',            '+96170200008'),
    ('Fluorescent Minerals Night',    '+96170200004'),
    ('Fluorescent Minerals Night',    '+96170200009'),
    ('Radioactive Minerals Seminar',  '+96170200001'),
    ('Radioactive Minerals Seminar',  '+96170200010'),
    ('Treasure Vault Preview',        '+96170200002'),
    ('Treasure Vault Preview',        '+96170200005'),
    ('Annual Gala & Donor Reception', '+96170200002'),
    ('Annual Gala & Donor Reception', '+96170200005')
) AS v(event_name, phone)
JOIN events e ON e.event_name = v.event_name
JOIN guests g ON g.phone_num  = v.phone;


-- 13. DONATIONS

IF NOT EXISTS (SELECT 1 FROM donations WHERE donation_date = '2024-01-10' AND amount = 50000.00)
INSERT INTO donations (donor_id, amount, donation_type, donation_date, note, event_id) VALUES
(NULL,
    50000.00, 'standard', '2024-01-10', 'Lead sponsor - Opening Night', NULL),

((SELECT guest_id FROM guests WHERE phone_num = '+96170200002'),
    5000.00, 'event', '2024-01-15', 'Education & outreach fund',
    (SELECT event_id FROM events WHERE event_name = 'Museum Opening Night')),

(NULL,
    10000.00, 'standard', '2024-02-14', 'Acquisition fund', NULL),

((SELECT guest_id FROM guests WHERE phone_num = '+96170200003'),
    1000.00, 'event', '2024-04-06', 'Donated at the Mineral Fair',
    (SELECT event_id FROM events WHERE event_name = 'Gem & Mineral Fair')),

(NULL,
    500.00, 'standard', '2024-05-01', NULL, NULL),

(NULL,
    25000.00, 'standard', '2024-06-15', 'Technology & display upgrade', NULL),

((SELECT guest_id FROM guests WHERE phone_num = '+96170200008'),
    750.00, 'standard', '2024-09-20', NULL, NULL),

(NULL,
    15000.00, 'standard', '2024-11-30', 'Acquisition fund', NULL),

((SELECT guest_id FROM guests WHERE phone_num = '+96170200002'),
    8000.00, 'standard', '2024-10-01', 'Annual education outreach', NULL),

((SELECT guest_id FROM guests WHERE phone_num = '+96170200009'),
    2000.00, 'standard', '2025-01-15', NULL, NULL),

((SELECT guest_id FROM guests WHERE phone_num = '+96170200005'),
    12000.00, 'event', '2025-02-20', '2025 Annual Gala sponsor',
    (SELECT event_id FROM events WHERE event_name = 'Annual Gala & Donor Reception'));


-- 14. BOUTIQUE CUSTOMERS

IF NOT EXISTS (SELECT 1 FROM customers WHERE phone_num = '+96170100001')
INSERT INTO customers (first_name, last_name, gender, email, phone_num) VALUES
('Karim',     'Haddad',     'male',   'karim.haddad@email.com',      '+96170100001'),
('Lara',      'Gemayel',    'female', 'lara.gemayel@email.com',      '+96170100002'),
('Omar',      'Khalil',     'male',   'omar.khalil@email.com',       '+96170100003'),
('Maya',      'Frem',       'female', 'maya.frem@email.com',         '+96170100004'),
('Tarek',     'Azzi',       'male',   'tarek.azzi@email.com',        '+96170100005'),
('Joelle',    'Raad',       'female', 'joelle.raad@email.com',       '+96170100006'),
('Charbel',   'Abou Jaoude','male',   'charbel.aboujaoude@email.com','+96170100007'),
('Nour',      'Hajj',       'female', 'nour.hajj@email.com',         '+96170100008'),
('Georges',   'Khoury',     'male',   'georges.khoury@email.com',    '+96170100009'),
('Rima',      'Nassar',     'female', 'rima.nassar@email.com',       '+96170100010'),
('Elie',      'Abboud',     'male',   'elie.abboud@email.com',       '+96170100011'),
('Carla',     'Tabet',      'female', 'carla.tabet@email.com',       '+96170100012'),
('Jad',       'Matar',      'male',   'jad.matar@email.com',         '+96170100013'),
('Hana',      'Rizk',       'female', 'hana.rizk@email.com',         '+96170100014'),
('Celine',    'Moussawi',   'female', 'celine.moussawi@email.com',   '+96170100015'),
('Anthony',   'Yazbeck',    'male',   'anthony.yazbeck@email.com',   '+96170100016'),
('Nadine',    'Saad',       'female', 'nadine.saad@email.com',       '+96170100017'),
('Pierre',    'Attieh',     'male',   'pierre.attieh@email.com',     '+96170100018'),
('Sandra',    'Bou Khalil', 'female', 'sandra.boukhalil@email.com',  '+96170100019'),
('Fadi',      'Nasr',       'male',   'fadi.nasr@email.com',         '+96170100020'),
('Rita',      'Karam',      'female', 'rita.karam@email.com',        '+96170100021'),
('Michel',    'Daou',       'male',   'michel.daou@email.com',       '+96170100022'),
('Lea',       'Azar',       'female', 'lea.azar@email.com',          '+96170100023'),
('Joe',       'Sleiman',    'male',   'joe.sleiman@email.com',       '+96170100024'),
('Tracy',     'Eid',        'female', 'tracy.eid@email.com',         '+96170100025'),
('Rabih',     'Harb',       'male',   'rabih.harb@email.com',        '+96170100026'),
('Christelle','Skaff',      'female', 'christelle.skaff@email.com',  '+96170100027'),
('Walid',     'Bou Hamdan', 'male',   'walid.bouhamdan@email.com',   '+96170100028'),
('Aline',     'Hatem',      'female', 'aline.hatem@email.com',       '+96170100029'),
('Marc',      'Sassine',    'male',   'marc.sassine@email.com',      '+96170100030');


-- 15. BOUTIQUE ITEMS

IF NOT EXISTS (SELECT 1 FROM boutique_items WHERE item_name = 'Fluorite Owl')
INSERT INTO boutique_items (item_name, unit_price, quantity, date_added, ref_mineral, is_active) VALUES
('Fluorite Owl',                16.00, 20, '2024-01-10', NULL, 1),  -- 801
('Kunzite Bracelet',            18.00, 30, '2024-01-10', NULL, 1),  -- 802
('Rose Quartz Cup',            130.00,  4, '2024-01-15', NULL, 1),  -- 803
('Rose Quartz Vase',           175.00,  3, '2024-01-15', NULL, 1),  -- 804
('Malachite Tower',             30.00, 10, '2024-02-01', NULL, 1),  -- 805
('Amazonite Tower',             40.00,  8, '2024-02-01', NULL, 1),  -- 806
('Sodalite Soap Bottle',        55.00,  6, '2024-02-10', NULL, 1),  -- 807
('Aventurine Soap Bottle',      55.00,  6, '2024-02-10', NULL, 1),  -- 808
('Obsidian Soap Bottle',        55.00,  6, '2024-03-01', NULL, 1),  -- 809
('Corundum Heart',              20.00, 15, '2024-03-01', NULL, 1),  -- 810
('Selenite Heart',              15.00, 25, '2024-03-05', NULL, 1),  -- 811
('Bloodstone Dragon',           30.00,  5, '2024-03-05', NULL, 1),  -- 812
('Obsidian Dragon',             30.00,  5, '2024-03-15', NULL, 1),  -- 813
('Amethyst Mirror',            375.00,  2, '2024-03-15', NULL, 1),  -- 814
('Wooden Himalayan Salt Lamp',  15.00, 18, '2024-04-01', NULL, 1),  -- 815
('Pyrite Cube (Natural)',       22.99, 20, '2024-04-01', NULL, 1),  -- 816
('Mixed Crystal Set (6pc)',     44.99, 10, '2024-04-10', NULL, 1),  -- 817
('Mineral ID Booklet',           8.99, 50, '2024-04-15', NULL, 1),  -- 818
('Geology Kids Kit',            24.99, 14, '2024-05-01', NULL, 1),  -- 819
('Museum Logo Tote Bag',        12.99, 70, '2024-05-10', NULL, 1);  -- 820


-- 16. TRANSACTIONS & TRANSACTION ITEMS

-- Item prices for reference (item_price column = snapshot at time of purchase):
--  801 Fluorite Owl            $16.00   809 Obsidian Soap Bottle   $55.00
--  802 Kunzite Bracelet        $18.00   810 Corundum Heart         $20.00
--  803 Rose Quartz Cup        $130.00   811 Selenite Heart         $15.00
--  804 Rose Quartz Vase       $175.00   813 Obsidian Dragon        $30.00
--  805 Malachite Tower         $30.00   814 Amethyst Mirror       $375.00
--  806 Amazonite Tower         $40.00   815 Wooden Salt Lamp       $15.00
--  807 Sodalite Soap Bottle    $55.00   816 Pyrite Cube            $22.99
--  808 Aventurine Soap Bottle  $55.00   817 Mixed Crystal Set      $44.99
--                                       818 Mineral ID Booklet      $8.99
--                                       819 Geology Kids Kit       $24.99
--                                       820 Museum Logo Tote       $12.99

DECLARE @u UNIQUEIDENTIFIER;

-- 706: 2× Obsidian Soap Bottle (809) → subtotal=110.00, vat=12.10, total=122.10
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,706,110.00,12.10,122.10,'cash',130.00,7.90,'2024-03-10 10:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,809,2,55.00);
-- 706: 1× Geology Kids Kit (819) → subtotal=24.99, vat=2.75, total=27.74
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,706,24.99,2.75,27.74,'card',NULL,NULL,'2024-09-18 14:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,819,1,24.99);

-- 707: 1× Wooden Salt Lamp (815) → subtotal=15.00, vat=1.65, total=16.65
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,707,15.00,1.65,16.65,'cash',20.00,3.35,'2024-04-05 11:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,815,1,15.00);
-- 707: 1× Obsidian Dragon (813) → subtotal=30.00, vat=3.30, total=33.30
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,707,30.00,3.30,33.30,'card',NULL,NULL,'2024-11-01 15:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,813,1,30.00);

-- 708: 1× Sodalite Soap Bottle (807) → subtotal=55.00, vat=6.05, total=61.05
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,708,55.00,6.05,61.05,'cash',70.00,8.95,'2024-04-20 09:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,807,1,55.00);
-- 708: 1× Museum Logo Tote (820) → subtotal=12.99, vat=1.43, total=14.42
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,708,12.99,1.43,14.42,'card',NULL,NULL,'2024-10-08 13:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,820,1,12.99);

-- 709: 1× Rose Quartz Vase (804) + 1× Aventurine Soap Bottle (808) → subtotal=230.00, vat=25.30, total=255.30
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,709,230.00,25.30,255.30,'card',NULL,NULL,'2024-05-12 10:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,804,1,175.00),(@u,808,1,55.00);
-- 709: 1× Mineral ID Booklet (818) → subtotal=8.99, vat=0.99, total=9.98
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,709,8.99,0.99,9.98,'cash',10.00,0.02,'2024-11-25 11:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,818,1,8.99);

-- 710: 1× Mixed Crystal Set (817) → subtotal=44.99, vat=4.95, total=49.94
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,710,44.99,4.95,49.94,'card',NULL,NULL,'2024-05-28 14:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,817,1,44.99);
-- 710: 2× Pyrite Cube (816) → subtotal=45.98, vat=5.06, total=51.04
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,710,45.98,5.06,51.04,'cash',60.00,8.96,'2024-12-10 10:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,816,2,22.99);

-- 711: 1× Fluorite Owl (801) → subtotal=16.00, vat=1.76, total=17.76
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,711,16.00,1.76,17.76,'cash',20.00,2.24,'2024-06-03 09:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,801,1,16.00);
-- 711: 1× Aventurine Soap Bottle (808) → subtotal=55.00, vat=6.05, total=61.05
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,711,55.00,6.05,61.05,'card',NULL,NULL,'2025-01-10 15:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,808,1,55.00);

-- 712: 1× Amethyst Mirror (814) → subtotal=375.00, vat=41.25, total=416.25
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,712,375.00,41.25,416.25,'card',NULL,NULL,'2024-06-17 11:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,814,1,375.00);
-- 712: 1× Amazonite Tower (806) → subtotal=40.00, vat=4.40, total=44.40
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,712,40.00,4.40,44.40,'cash',50.00,5.60,'2024-12-20 16:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,806,1,40.00);

-- 713: 1× Pyrite Cube (816) → subtotal=22.99, vat=2.53, total=25.52
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,713,22.99,2.53,25.52,'cash',30.00,4.48,'2024-07-01 10:15:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,816,1,22.99);
-- 713: 1× Corundum Heart (810) → subtotal=20.00, vat=2.20, total=22.20
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,713,20.00,2.20,22.20,'card',NULL,NULL,'2025-01-14 13:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,810,1,20.00);

-- 714: 1× Rose Quartz Cup (803) → subtotal=130.00, vat=14.30, total=144.30
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,714,130.00,14.30,144.30,'card',NULL,NULL,'2024-07-15 09:45:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,803,1,130.00);
-- 714: 1× Sodalite Soap Bottle (807) → subtotal=55.00, vat=6.05, total=61.05
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,714,55.00,6.05,61.05,'cash',70.00,8.95,'2024-12-05 14:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,807,1,55.00);

-- 715: 1× Kunzite Bracelet (802) → subtotal=18.00, vat=1.98, total=19.98
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,715,18.00,1.98,19.98,'cash',20.00,0.02,'2024-07-29 11:20:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,802,1,18.00);
-- 715: 1× Malachite Tower (805) → subtotal=30.00, vat=3.30, total=33.30
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,715,30.00,3.30,33.30,'card',NULL,NULL,'2025-02-01 10:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,805,1,30.00);

-- Walk-ins
-- Selenite Heart (811) → subtotal=15.00, vat=1.65, total=16.65
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,NULL,15.00,1.65,16.65,'cash',20.00,3.35,'2024-01-18 14:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,811,1,15.00);
-- Obsidian Soap Bottle (809) → subtotal=55.00, vat=6.05, total=61.05
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,NULL,55.00,6.05,61.05,'cash',70.00,8.95,'2024-02-03 11:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,809,1,55.00);
-- Museum Logo Tote (820) → subtotal=12.99, vat=1.43, total=14.42
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,NULL,12.99,1.43,14.42,'card',NULL,NULL,'2024-03-25 10:00:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,820,1,12.99);
-- Geology Kids Kit (819) → subtotal=24.99, vat=2.75, total=27.74
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,NULL,24.99,2.75,27.74,'cash',30.00,2.26,'2024-04-14 15:20:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,819,1,24.99);
-- Mixed Crystal Set (817) → subtotal=44.99, vat=4.95, total=49.94
SET @u=NEWID(); INSERT INTO transactions(trans_uuid,customer_id,subtotal,vat,total,payment_method,amount_paid,change_due,created_at,employee_id)VALUES(@u,NULL,44.99,4.95,49.94,'cash',50.00,0.06,'2025-02-11 14:30:00',(SELECT employee_id FROM employees WHERE email='john.doe@mim.museum')); INSERT INTO transaction_items VALUES(@u,817,1,44.99);