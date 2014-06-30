// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.ModelConfiguration.Configuration
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     Used to configure a <see cref="T:System.byte[]" /> property of an entity type or complex type.
    ///     This configuration functionality is available via the Code First Fluent API, see <see cref="DbModelBuilder" />.
    /// </summary>
    public class BinaryPropertyConfiguration : LengthPropertyConfiguration<Properties.Primitive.BinaryPropertyConfiguration>
    {
        internal BinaryPropertyConfiguration(Properties.Primitive.BinaryPropertyConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        ///     Configures the property to allow the maximum length supported by the database provider.
        /// </summary>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration IsMaxLength()
        {
            base.IsMaxLength();

            return this;
        }

        /// <summary>
        ///     Configures the property to have the specified maximum length.
        /// </summary>
        /// <param name="value"> The maximum length for the property. Setting 'null' will remove any maximum length restriction from the property. </param>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration HasMaxLength(int? value)
        {
            base.HasMaxLength(value);

            return this;
        }

        /// <summary>
        ///     Configures the property to be fixed length.
        ///     Use HasMaxLength to set the length that the property is fixed to.
        /// </summary>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration IsFixedLength()
        {
            base.IsFixedLength();

            return this;
        }

        /// <summary>
        ///     Configures the property to be variable length.
        ///     <see cref="T:System.byte[]" /> properties are variable length by default.
        /// </summary>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration IsVariableLength()
        {
            base.IsVariableLength();

            return this;
        }

        /// <summary>
        ///     Configures the property to be optional.
        ///     The database column used to store this property will be nullable.
        ///     <see cref="T:System.byte[]" /> properties are optional by default.
        /// </summary>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration IsOptional()
        {
            base.IsOptional();

            return this;
        }

        /// <summary>
        ///     Configures the property to be required.
        ///     The database column used to store this property will be non-nullable.
        /// </summary>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration IsRequired()
        {
            base.IsRequired();

            return this;
        }

        /// <summary>
        ///     Configures how values for the property are generated by the database.
        /// </summary>
        /// <param name="databaseGeneratedOption"> The pattern used to generate values for the property in the database. Setting 'null' will remove the database generated pattern facet from the property. Setting 'null' will cause the same runtime behavior as specifying 'None'. </param>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration HasDatabaseGeneratedOption(
            DatabaseGeneratedOption? databaseGeneratedOption)
        {
            base.HasDatabaseGeneratedOption(databaseGeneratedOption);

            return this;
        }

        /// <summary>
        ///     Configures the property to be used as an optimistic concurrency token.
        /// </summary>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration IsConcurrencyToken()
        {
            base.IsConcurrencyToken();

            return this;
        }

        /// <summary>
        ///     Configures whether or not the property is to be used as an optimistic concurrency token.
        /// </summary>
        /// <param name="concurrencyToken"> Value indicating if the property is a concurrency token or not. Specifying 'null' will remove the concurrency token facet from the property. Specifying 'null' will cause the same runtime behavior as specifying 'false'. </param>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
        {
            base.IsConcurrencyToken(concurrencyToken);

            return this;
        }

        /// <summary>
        ///     Configures the name of the database column used to store the property.
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration HasColumnName(string columnName)
        {
            base.HasColumnName(columnName);

            return this;
        }

        /// <summary>
        ///     Configures the data type of the database column used to store the property.
        /// </summary>
        /// <param name="columnType"> Name of the database provider specific data type. </param>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration HasColumnType(string columnType)
        {
            base.HasColumnType(columnType);

            return this;
        }

        /// <summary>
        ///     Configures the order of the database column used to store the property.
        ///     This method is also used to specify key ordering when an entity type has a composite key.
        /// </summary>
        /// <param name="columnOrder"> The order that this column should appear in the database table. </param>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new BinaryPropertyConfiguration HasColumnOrder(int? columnOrder)
        {
            base.HasColumnOrder(columnOrder);

            return this;
        }

        /// <summary>
        ///     Configures the property to be a row version in the database.
        ///     The actual data type will vary depending on the database provider being used.
        ///     Setting the property to be a row version will automatically configure it to be an
        ///     optimistic concurrency token.
        /// </summary>
        /// <returns> The same BinaryPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public BinaryPropertyConfiguration IsRowVersion()
        {
            Configuration.IsRowVersion = true;

            return this;
        }
    }
}
