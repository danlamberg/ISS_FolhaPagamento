-- CreateTable
CREATE TABLE "Folha" (
    "id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    "funcionario" TEXT NOT NULL,
    "cpf" TEXT NOT NULL,
    "horas" INTEGER NOT NULL DEFAULT 0,
    "valor" REAL NOT NULL DEFAULT 0,
    "bruto" REAL NOT NULL DEFAULT 0,
    "liquido" REAL NOT NULL DEFAULT 0,
    "irrf" REAL NOT NULL DEFAULT 0,
    "inss" REAL NOT NULL DEFAULT 0,
    "fgts" REAL NOT NULL DEFAULT 0,
    "calculado" BOOLEAN NOT NULL DEFAULT false
);
