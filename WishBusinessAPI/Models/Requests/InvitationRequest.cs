﻿namespace WishBusinessAPI.Models.Requests
{
    public class InvitationRequest
    {
        public int invitationId { get; set; }
        public int userId { get; set; }
        public string invitationCode { get; set; }
        public string shareAddress { get; set; }
    }
}
