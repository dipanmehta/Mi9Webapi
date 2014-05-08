using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi9Project.Models.Repository
{
    public interface IPayloadRepository
    {
        List<Show> processPayload(Payload payload);
    }
}
