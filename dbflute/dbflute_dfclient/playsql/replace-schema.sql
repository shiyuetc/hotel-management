-- KbnRank
CREATE TABLE "kbn_rank" (
    "code" VARCHAR(3) NOT NULL PRIMARY KEY,
    "name" VARCHAR(20) NOT NULL
)

-- MstEmployee
CREATE TABLE "mst_employee" (
    "id" SERIAL NOT NULL PRIMARY KEY,
    "employee_no" VARCHAR(20) UNIQUE NOT NULL,
    "name" VARCHAR(50) NOT NULL,
    "password" VARCHAR(255) NOT NULL,
    "rank_code" VARCHAR(3) NOT NULL,
    "join_date_time" TIMESTAMP(3) NOT NULL,
    "leave_date_time" TIMESTAMP(3) NOT NULL
)

-- MstCustomer
CREATE TABLE "mst_customer" (
    "id" SERIAL NOT NULL PRIMARY KEY,
    "name" VARCHAR(50) NOT NULL,
)