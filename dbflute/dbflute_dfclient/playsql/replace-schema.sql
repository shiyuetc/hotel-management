
CREATE TABLE "mst_user" (
    "id" SERIAL NOT NULL PRIMARY KEY,
    "login_name" VARCHAR(20) UNIQUE NOT NULL,
    "name" VARCHAR(40) NOT NULL,
    "password" VARCHAR(255) NOT NULL,
    "update_time" TIMESTAMP(3) NOT NULL,
    "update_user" VARCHAR(100) NOT NULL,
    "version_no" BIGINT NOT NULL
)
