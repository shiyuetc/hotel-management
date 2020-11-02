
CREATE TABLE "mst_user" (
    "id" SERIAL NOT NULL PRIMARY KEY,
    "name" VARCHAR(20) NOT NULL,
    "password" VARCHAR(255) NOT NULL,
    "update_time" TIMESTAMP(3) NOT NULL,
    "update_user" VARCHAR(200) NOT NULL,
    "version_no" BIGINT NOT NULL
)
