// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Input for the task that migrates Oracle databases to Azure Database for
    /// PostgreSQL for online migrations
    /// </summary>
    public partial class MigrateOracleAzureDbPostgreSqlSyncTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrateOracleAzureDbPostgreSqlSyncTaskInput class.
        /// </summary>
        public MigrateOracleAzureDbPostgreSqlSyncTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrateOracleAzureDbPostgreSqlSyncTaskInput class.
        /// </summary>
        /// <param name="selectedDatabases">Databases to migrate</param>
        /// <param name="targetConnectionInfo">Connection information for
        /// target Azure Database for PostgreSQL</param>
        /// <param name="sourceConnectionInfo">Connection information for
        /// source Oracle</param>
        public MigrateOracleAzureDbPostgreSqlSyncTaskInput(IList<MigrateOracleAzureDbPostgreSqlSyncDatabaseInput> selectedDatabases, PostgreSqlConnectionInfo targetConnectionInfo, OracleConnectionInfo sourceConnectionInfo)
        {
            SelectedDatabases = selectedDatabases;
            TargetConnectionInfo = targetConnectionInfo;
            SourceConnectionInfo = sourceConnectionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets databases to migrate
        /// </summary>
        [JsonProperty(PropertyName = "selectedDatabases")]
        public IList<MigrateOracleAzureDbPostgreSqlSyncDatabaseInput> SelectedDatabases { get; set; }

        /// <summary>
        /// Gets or sets connection information for target Azure Database for
        /// PostgreSQL
        /// </summary>
        [JsonProperty(PropertyName = "targetConnectionInfo")]
        public PostgreSqlConnectionInfo TargetConnectionInfo { get; set; }

        /// <summary>
        /// Gets or sets connection information for source Oracle
        /// </summary>
        [JsonProperty(PropertyName = "sourceConnectionInfo")]
        public OracleConnectionInfo SourceConnectionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SelectedDatabases == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SelectedDatabases");
            }
            if (TargetConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetConnectionInfo");
            }
            if (SourceConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceConnectionInfo");
            }
            if (TargetConnectionInfo != null)
            {
                TargetConnectionInfo.Validate();
            }
            if (SourceConnectionInfo != null)
            {
                SourceConnectionInfo.Validate();
            }
        }
    }
}
