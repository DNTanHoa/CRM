using CRM.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Models.Repositories
{
    public interface ISequenceNumberRepository
    {
        public bool GetNextNumber(string partern, string serial, out string nextNumber);
    }
    public class SequenceNumberRepository : ISequenceNumberRepository
    {
        private readonly AppDbContext context;

        public SequenceNumberRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool GetNextNumber(string partern, string serial, out string nextNumber)
        {
            nextNumber = string.Empty;
            var sequenceNumber = context.SequenceNumber.FirstOrDefault(x => x.partern == partern &&
                                                                            x.serial == serial);

            if(sequenceNumber != null)
            {
                bool parseNumberResult = false;

                parseNumberResult = int.TryParse(sequenceNumber.lastNumber, out int numberTo);

                if(parseNumberResult)
                {
                    nextNumber = (numberTo + 1).ToString().PadLeft(sequenceNumber.lastNumber.Length, '0');
                    sequenceNumber.lastNumber = nextNumber;
                    return true;
                }
            }

            return false;
        }
    }
}
