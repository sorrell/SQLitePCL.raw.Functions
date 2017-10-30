# SQLitePCL.raw.Functions

These are extension functions for SQLite that can be added to a SQLitePCLRaw DB.

## How to Use

```
static sqlite3 db;
SQLitePCL.Batteries.Init();
raw.sqlite3_open(":memory:", out db);
RawFn.Init(db);
```

We can now query SQLite using the functions in this library:

```
SELECT ISINT(5);
-- Returns 1

SELECT ISINT('X');
-- Returns 0
```
