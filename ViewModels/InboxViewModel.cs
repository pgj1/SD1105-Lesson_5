using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BlindDating.Models;

namespace BlindDating.ViewModels
{
    public class InboxViewModel
    {

        public IEnumerable<MailMessage> mailMessages;
        public IEnumerable<DatingProfile> fromProfiles;


    }
}
