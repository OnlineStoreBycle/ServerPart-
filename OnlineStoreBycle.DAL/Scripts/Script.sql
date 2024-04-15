﻿CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE "BrandBycles" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "Name" text NOT NULL,
    CONSTRAINT "PK_BrandBycles" PRIMARY KEY ("Id")
);

CREATE TABLE "BycleTypes" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "Name" text NOT NULL,
    CONSTRAINT "PK_BycleTypes" PRIMARY KEY ("Id")
);

CREATE TABLE "Clients" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "Name" text NOT NULL,
    "Password" text NOT NULL,
    "Email" text NOT NULL,
    "Phone" text NOT NULL,
    "Address" text NOT NULL,
    CONSTRAINT "PK_Clients" PRIMARY KEY ("Id")
);

CREATE TABLE "FrameSizes" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "Value" integer NOT NULL,
    CONSTRAINT "PK_FrameSizes" PRIMARY KEY ("Id")
);

CREATE TABLE "Statuses" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "Name" text NOT NULL,
    CONSTRAINT "PK_Statuses" PRIMARY KEY ("Id")
);

CREATE TABLE "Bycles" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "BrandId" integer NOT NULL,
    "TypeId" integer NOT NULL,
    "FrameSizeId" integer NOT NULL,
    "IsBooked" boolean NOT NULL,
    "FrameMaterialName" text,
    "Weight" numeric NOT NULL,
    "WheelDiameter" integer NOT NULL,
    "CountSpeed" integer NOT NULL,
    "IsDepreciation" boolean NOT NULL,
    "ImageLink" text,
    "Title" text,
    CONSTRAINT "PK_Bycles" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Bycles_BrandBycles_BrandId" FOREIGN KEY ("BrandId") REFERENCES "BrandBycles" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Bycles_BycleTypes_TypeId" FOREIGN KEY ("TypeId") REFERENCES "BycleTypes" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Bycles_FrameSizes_FrameSizeId" FOREIGN KEY ("FrameSizeId") REFERENCES "FrameSizes" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Orders" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "ClientId" integer NOT NULL,
    "StatusId" integer NOT NULL,
    "Number" text NOT NULL,
    "TypeName" text NOT NULL,
    "PaymentMethod" text NOT NULL,
    "AddressReturn" text NOT NULL,
    "DateBegin" timestamp with time zone NOT NULL,
    "DateEnd" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_Orders" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Orders_Clients_ClientId" FOREIGN KEY ("ClientId") REFERENCES "Clients" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Orders_Statuses_StatusId" FOREIGN KEY ("StatusId") REFERENCES "Statuses" ("Id") ON DELETE CASCADE
);

CREATE TABLE "NumberBycles" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "BycleId" integer NOT NULL,
    "Value" text NOT NULL,
    CONSTRAINT "PK_NumberBycles" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_NumberBycles_Bycles_BycleId" FOREIGN KEY ("BycleId") REFERENCES "Bycles" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Prices" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "BycleId" integer NOT NULL,
    "Value" numeric NOT NULL,
    "DateBegin" timestamp with time zone NOT NULL,
    "DateEnd" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_Prices" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Prices_Bycles_BycleId" FOREIGN KEY ("BycleId") REFERENCES "Bycles" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Reviews" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "BycleId" integer NOT NULL,
    "Text" text NOT NULL,
    CONSTRAINT "PK_Reviews" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Reviews_Bycles_BycleId" FOREIGN KEY ("BycleId") REFERENCES "Bycles" ("Id") ON DELETE CASCADE
);

CREATE TABLE "OrderBycles" (
    "Id" integer GENERATED BY DEFAULT AS IDENTITY,
    "OrderId" integer NOT NULL,
    "NumberBycleId" integer NOT NULL,
    "IsLantern" boolean NOT NULL,
    "IsHelmet" boolean NOT NULL,
    "IsCastle" boolean NOT NULL,
    CONSTRAINT "PK_OrderBycles" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_OrderBycles_NumberBycles_NumberBycleId" FOREIGN KEY ("NumberBycleId") REFERENCES "NumberBycles" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderBycles_Orders_OrderId" FOREIGN KEY ("OrderId") REFERENCES "Orders" ("Id") ON DELETE CASCADE
);

INSERT INTO "BycleTypes" ("Id", "Name")
VALUES (1, 'M');
INSERT INTO "BycleTypes" ("Id", "Name")
VALUES (2, 'E');
INSERT INTO "BycleTypes" ("Id", "Name")
VALUES (3, 'W');

CREATE INDEX "IX_Bycles_BrandId" ON "Bycles" ("BrandId");

CREATE INDEX "IX_Bycles_FrameSizeId" ON "Bycles" ("FrameSizeId");

CREATE INDEX "IX_Bycles_TypeId" ON "Bycles" ("TypeId");

CREATE INDEX "IX_NumberBycles_BycleId" ON "NumberBycles" ("BycleId");

CREATE INDEX "IX_OrderBycles_NumberBycleId" ON "OrderBycles" ("NumberBycleId");

CREATE INDEX "IX_OrderBycles_OrderId" ON "OrderBycles" ("OrderId");

CREATE INDEX "IX_Orders_ClientId" ON "Orders" ("ClientId");

CREATE INDEX "IX_Orders_StatusId" ON "Orders" ("StatusId");

CREATE INDEX "IX_Prices_BycleId" ON "Prices" ("BycleId");

CREATE INDEX "IX_Reviews_BycleId" ON "Reviews" ("BycleId");

SELECT setval(
    pg_get_serial_sequence('"BycleTypes"', 'Id'),
    GREATEST(
        (SELECT MAX("Id") FROM "BycleTypes") + 1,
        nextval(pg_get_serial_sequence('"BycleTypes"', 'Id'))),
    false);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240414164009_Init', '8.0.3');

COMMIT;
