﻿namespace ContactsAPI.Models.DTO
{
    public class UpdateContactRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
    }
}
