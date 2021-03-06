﻿using System;

namespace Dramonkiller.CareHomeApp.Domain.Entities.Residents
{
    public class Resident : IEntityBase
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Middle { get; set; }

        public string Surname { get; set; }

        public string FullName { get; set; }

        public string DocumentId { get; set; }

        public DateTime? Birthdate { get; set; }

        public int? Age { get; set; }

        public Gender? Gender { get; set; }

        public string Notifications { get; set; }

        public string Comments { get; set; }

        public virtual ResidentPhoto PhotoData { get; set; }

        public void UpdateFullName()
        {
            FullName = string.Format("{0} {1} {2}", Name, Middle, Surname).TrimEnd(); 
        }
    }
}
