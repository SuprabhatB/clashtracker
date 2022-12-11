using EnsureThat;

namespace ClashTracker.Client.Utilities.Helpers
{
    public class StringHelper : IStringHelper
    {
        private readonly IIdGenerator _idGenerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringHelper"/> class.
        /// </summary>
        /// <param name="idGenerator">The identifier generator.</param>
        public StringHelper(IIdGenerator idGenerator)
        {
            EnsureArg.IsNotNull(idGenerator, nameof(idGenerator));

            _idGenerator = idGenerator;
        }

        /// <summary>
        /// Generates the element u identifier if empty.
        /// </summary>
        /// <param name="existingId">The existing identifier.</param>
        /// <param name="newId">The new identifier.</param>
        /// <returns></returns>
        public string GenerateElementUIdIfEmpty(string existingId, string newId)
        {
            var uid = existingId;
            if (string.IsNullOrWhiteSpace(existingId))
            {
                uid = string.IsNullOrWhiteSpace(newId) ? _idGenerator.Generate : newId;
            }

            return uid;
        }
    }
}
