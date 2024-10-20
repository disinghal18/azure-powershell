// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// A2A managed disk input details.
    /// </summary>
    public partial class A2AVmManagedDiskInputDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AVmManagedDiskInputDetails class.
        /// </summary>
        public A2AVmManagedDiskInputDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AVmManagedDiskInputDetails class.
        /// </summary>

        /// <param name="diskId">The disk Id.
        /// </param>

        /// <param name="primaryStagingAzureStorageAccountId">The primary staging storage account Arm Id.
        /// </param>

        /// <param name="recoveryResourceGroupId">The target resource group Arm Id.
        /// </param>

        /// <param name="recoveryReplicaDiskAccountType">The replica disk type. Its an optional value and will be same as source
        /// disk type if not user provided.
        /// </param>

        /// <param name="recoveryTargetDiskAccountType">The target disk type after failover. Its an optional value and will be same
        /// as source disk type if not user provided.
        /// </param>

        /// <param name="recoveryDiskEncryptionSetId">The recovery disk encryption set Id.
        /// </param>

        /// <param name="diskEncryptionInfo">The recovery disk encryption information (for one / single pass flows).
        /// </param>
        public A2AVmManagedDiskInputDetails(string diskId, string primaryStagingAzureStorageAccountId, string recoveryResourceGroupId, string recoveryReplicaDiskAccountType = default(string), string recoveryTargetDiskAccountType = default(string), string recoveryDiskEncryptionSetId = default(string), DiskEncryptionInfo diskEncryptionInfo = default(DiskEncryptionInfo))

        {
            this.DiskId = diskId;
            this.PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            this.RecoveryResourceGroupId = recoveryResourceGroupId;
            this.RecoveryReplicaDiskAccountType = recoveryReplicaDiskAccountType;
            this.RecoveryTargetDiskAccountType = recoveryTargetDiskAccountType;
            this.RecoveryDiskEncryptionSetId = recoveryDiskEncryptionSetId;
            this.DiskEncryptionInfo = diskEncryptionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the disk Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskId")]
        public string DiskId {get; set; }

        /// <summary>
        /// Gets or sets the primary staging storage account Arm Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryStagingAzureStorageAccountId")]
        public string PrimaryStagingAzureStorageAccountId {get; set; }

        /// <summary>
        /// Gets or sets the target resource group Arm Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId {get; set; }

        /// <summary>
        /// Gets or sets the replica disk type. Its an optional value and will be same
        /// as source disk type if not user provided.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryReplicaDiskAccountType")]
        public string RecoveryReplicaDiskAccountType {get; set; }

        /// <summary>
        /// Gets or sets the target disk type after failover. Its an optional value and
        /// will be same as source disk type if not user provided.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryTargetDiskAccountType")]
        public string RecoveryTargetDiskAccountType {get; set; }

        /// <summary>
        /// Gets or sets the recovery disk encryption set Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryDiskEncryptionSetId")]
        public string RecoveryDiskEncryptionSetId {get; set; }

        /// <summary>
        /// Gets or sets the recovery disk encryption information (for one / single
        /// pass flows).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskEncryptionInfo")]
        public DiskEncryptionInfo DiskEncryptionInfo {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.DiskId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DiskId");
            }
            if (this.PrimaryStagingAzureStorageAccountId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PrimaryStagingAzureStorageAccountId");
            }
            if (this.RecoveryResourceGroupId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoveryResourceGroupId");
            }







        }
    }
}