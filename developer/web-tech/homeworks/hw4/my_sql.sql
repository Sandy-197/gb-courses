
-- create
CREATE TABLE STUDENTS (
  id INTEGER PRIMARY KEY,
  name TEXT NOT NULL,
  age INTEGER NOT  NULL,
  address TEXT NOT NULL
);

-- insert
INSERT INTO STUDENTS VALUES (1,'Ivanov', 23, 'Moscow....');
INSERT INTO STUDENTS VALUES (2,'Petrov', 27, 'Minsk...');
INSERT INTO STUDENTS VALUES (3, 'Abramov', 18, 'Moscow....');
INSERT INTO STUDENTS VALUES (4, 'Filipov', 30, 'Moscow...');
INSERT INTO STUDENTS VALUES (5, 'Petrov', 15, 'Chekhov...');
INSERT INTO STUDENTS VALUES (6, 'Kustov', 15, 'Moscow....');
INSERT INTO STUDENTS VALUES (7, 'Tarasov', 33, 'Cheboksary...');
INSERT INTO STUDENTS VALUES (8,'Grishin', 50, 'Minsk...');
INSERT INTO STUDENTS VALUES (9, 'Lubimov', 30, 'Orel....');


-- fetch 
SELECT * FROM STUDENTS WHERE address like '%Moscow%' AND age >=18 AND age<30;