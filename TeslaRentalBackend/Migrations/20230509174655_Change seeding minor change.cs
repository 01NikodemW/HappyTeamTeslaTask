using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeslaRentalBackend.Migrations
{
    /// <inheritdoc />
    public partial class Changeseedingminorchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0d2d2c68-6fb8-4ccf-981a-2e9ecb3c559f"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0f12b48e-39a3-4f17-8a70-36bba97ee5e1"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("1b8c1b10-4b8f-46e7-a3de-8cf7b89d3b49"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("1e310798-b8bf-48dd-b64a-7fdd6e27d6b3"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("1faa6b15-6f8d-44a2-97e2-09a8b7118e6b"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("2ab9aa72-7f07-43cc-88f3-e95d79afdc9c"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("5b5ef594-ebc9-47e9-84c5-56ef6821d49e"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6f2943a8-850c-48f8-8a9b-d7e8c7b14a10"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("72d61b31-73b3-4d1b-a72f-07620f2ca927"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("764fa43d-9d70-4deb-9b16-70b4eb3d13c6"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("78f725c3-c46a-45c3-9203-32a91f85330d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("7a837a61-3c24-438e-9f3b-20732e0c9887"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("81d1c534-8c39-4c68-b1bb-5d035d66e80e"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("8de0e6e5-0597-47d8-a8c7-84f873a77ab7"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("a5ef1a70-5d6f-4967-bc27-2f7386adbb8a"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("b0f0b0a0-0f0b-4b0f-8b0f-0b0f0b0f0b0f"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bc003c31-94a4-4336-9e02-4d322f7b22a8"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c0e95c11-48e8-4c68-bc38-95644d79cf20"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c2616203-4c46-4a7c-8eb2-c5d7859edce9"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4bbd2a5-df57-48f5-b04e-9a8e5c7a8173"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c7d743aa-d91e-4a21-9d08-6b2b4315c4a4"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c7e2a9b4-6f96-4df3-8a2d-56957c8ed700"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d2a91b91-5b5a-4c26-8705-5c5a19ca84a8"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e3189371-5742-42f8-b0e5-7566b1183836"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6bce5e6-05db-4f44-a4a6-69a3731ee084"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("f1b5b1b0-5c1f-4b1f-9c1f-08d8e1b5b1b0"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("f338c1f1-0e94-4163-9869-9cfb7452dbd7"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d2d2c68-6fb8-4ccf-981a-2e9ecb3c559f"), "Poland" },
                    { new Guid("0f12b48e-39a3-4f17-8a70-36bba97ee5e1"), "Slovakia" },
                    { new Guid("1b8c1b10-4b8f-46e7-a3de-8cf7b89d3b49"), "Romania" },
                    { new Guid("1e310798-b8bf-48dd-b64a-7fdd6e27d6b3"), "Netherlands" },
                    { new Guid("1faa6b15-6f8d-44a2-97e2-09a8b7118e6b"), "Belgium" },
                    { new Guid("2ab9aa72-7f07-43cc-88f3-e95d79afdc9c"), "Malta" },
                    { new Guid("5b5ef594-ebc9-47e9-84c5-56ef6821d49e"), "Croatia" },
                    { new Guid("6f2943a8-850c-48f8-8a9b-d7e8c7b14a10"), "Slovenia" },
                    { new Guid("72d61b31-73b3-4d1b-a72f-07620f2ca927"), "Lithuania" },
                    { new Guid("764fa43d-9d70-4deb-9b16-70b4eb3d13c6"), "Latvia" },
                    { new Guid("78f725c3-c46a-45c3-9203-32a91f85330d"), "Bulgaria" },
                    { new Guid("7a837a61-3c24-438e-9f3b-20732e0c9887"), "Estonia" },
                    { new Guid("81d1c534-8c39-4c68-b1bb-5d035d66e80e"), "Sweden" },
                    { new Guid("8de0e6e5-0597-47d8-a8c7-84f873a77ab7"), "Finland" },
                    { new Guid("a5ef1a70-5d6f-4967-bc27-2f7386adbb8a"), "Ireland" },
                    { new Guid("b0f0b0a0-0f0b-4b0f-8b0f-0b0f0b0f0b0f"), "Italy" },
                    { new Guid("bc003c31-94a4-4336-9e02-4d322f7b22a8"), "France" },
                    { new Guid("c0e95c11-48e8-4c68-bc38-95644d79cf20"), "Germany" },
                    { new Guid("c2616203-4c46-4a7c-8eb2-c5d7859edce9"), "Portugal" },
                    { new Guid("c4bbd2a5-df57-48f5-b04e-9a8e5c7a8173"), "Spain" },
                    { new Guid("c7d743aa-d91e-4a21-9d08-6b2b4315c4a4"), "Greece" },
                    { new Guid("c7e2a9b4-6f96-4df3-8a2d-56957c8ed700"), "Hungary" },
                    { new Guid("d2a91b91-5b5a-4c26-8705-5c5a19ca84a8"), "Cyprus" },
                    { new Guid("e3189371-5742-42f8-b0e5-7566b1183836"), "Czech Republic" },
                    { new Guid("e6bce5e6-05db-4f44-a4a6-69a3731ee084"), "Luxembourg" },
                    { new Guid("f1b5b1b0-5c1f-4b1f-9c1f-08d8e1b5b1b0"), "Austria" },
                    { new Guid("f338c1f1-0e94-4163-9869-9cfb7452dbd7"), "Denmark" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "Manacor" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Alcudia" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Palma Airport" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Palma City Center" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d2d2c68-6fb8-4ccf-981a-2e9ecb3c559f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f12b48e-39a3-4f17-8a70-36bba97ee5e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b8c1b10-4b8f-46e7-a3de-8cf7b89d3b49"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e310798-b8bf-48dd-b64a-7fdd6e27d6b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1faa6b15-6f8d-44a2-97e2-09a8b7118e6b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ab9aa72-7f07-43cc-88f3-e95d79afdc9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b5ef594-ebc9-47e9-84c5-56ef6821d49e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f2943a8-850c-48f8-8a9b-d7e8c7b14a10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72d61b31-73b3-4d1b-a72f-07620f2ca927"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("764fa43d-9d70-4deb-9b16-70b4eb3d13c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78f725c3-c46a-45c3-9203-32a91f85330d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a837a61-3c24-438e-9f3b-20732e0c9887"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81d1c534-8c39-4c68-b1bb-5d035d66e80e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8de0e6e5-0597-47d8-a8c7-84f873a77ab7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5ef1a70-5d6f-4967-bc27-2f7386adbb8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0f0b0a0-0f0b-4b0f-8b0f-0b0f0b0f0b0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc003c31-94a4-4336-9e02-4d322f7b22a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0e95c11-48e8-4c68-bc38-95644d79cf20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2616203-4c46-4a7c-8eb2-c5d7859edce9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4bbd2a5-df57-48f5-b04e-9a8e5c7a8173"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7d743aa-d91e-4a21-9d08-6b2b4315c4a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7e2a9b4-6f96-4df3-8a2d-56957c8ed700"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2a91b91-5b5a-4c26-8705-5c5a19ca84a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3189371-5742-42f8-b0e5-7566b1183836"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6bce5e6-05db-4f44-a4a6-69a3731ee084"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1b5b1b0-5c1f-4b1f-9c1f-08d8e1b5b1b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f338c1f1-0e94-4163-9869-9cfb7452dbd7"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "Manacor" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Alcudia" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Palma Airport" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Palma City Center" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d2d2c68-6fb8-4ccf-981a-2e9ecb3c559f"), "Poland" },
                    { new Guid("0f12b48e-39a3-4f17-8a70-36bba97ee5e1"), "Slovakia" },
                    { new Guid("1b8c1b10-4b8f-46e7-a3de-8cf7b89d3b49"), "Romania" },
                    { new Guid("1e310798-b8bf-48dd-b64a-7fdd6e27d6b3"), "Netherlands" },
                    { new Guid("1faa6b15-6f8d-44a2-97e2-09a8b7118e6b"), "Belgium" },
                    { new Guid("2ab9aa72-7f07-43cc-88f3-e95d79afdc9c"), "Malta" },
                    { new Guid("5b5ef594-ebc9-47e9-84c5-56ef6821d49e"), "Croatia" },
                    { new Guid("6f2943a8-850c-48f8-8a9b-d7e8c7b14a10"), "Slovenia" },
                    { new Guid("72d61b31-73b3-4d1b-a72f-07620f2ca927"), "Lithuania" },
                    { new Guid("764fa43d-9d70-4deb-9b16-70b4eb3d13c6"), "Latvia" },
                    { new Guid("78f725c3-c46a-45c3-9203-32a91f85330d"), "Bulgaria" },
                    { new Guid("7a837a61-3c24-438e-9f3b-20732e0c9887"), "Estonia" },
                    { new Guid("81d1c534-8c39-4c68-b1bb-5d035d66e80e"), "Sweden" },
                    { new Guid("8de0e6e5-0597-47d8-a8c7-84f873a77ab7"), "Finland" },
                    { new Guid("a5ef1a70-5d6f-4967-bc27-2f7386adbb8a"), "Ireland" },
                    { new Guid("b0f0b0a0-0f0b-4b0f-8b0f-0b0f0b0f0b0f"), "Italy" },
                    { new Guid("bc003c31-94a4-4336-9e02-4d322f7b22a8"), "France" },
                    { new Guid("c0e95c11-48e8-4c68-bc38-95644d79cf20"), "Germany" },
                    { new Guid("c2616203-4c46-4a7c-8eb2-c5d7859edce9"), "Portugal" },
                    { new Guid("c4bbd2a5-df57-48f5-b04e-9a8e5c7a8173"), "Spain" },
                    { new Guid("c7d743aa-d91e-4a21-9d08-6b2b4315c4a4"), "Greece" },
                    { new Guid("c7e2a9b4-6f96-4df3-8a2d-56957c8ed700"), "Hungary" },
                    { new Guid("d2a91b91-5b5a-4c26-8705-5c5a19ca84a8"), "Cyprus" },
                    { new Guid("e3189371-5742-42f8-b0e5-7566b1183836"), "Czech Republic" },
                    { new Guid("e6bce5e6-05db-4f44-a4a6-69a3731ee084"), "Luxembourg" },
                    { new Guid("f1b5b1b0-5c1f-4b1f-9c1f-08d8e1b5b1b0"), "Austria" },
                    { new Guid("f338c1f1-0e94-4163-9869-9cfb7452dbd7"), "Denmark" }
                });
        }
    }
}
