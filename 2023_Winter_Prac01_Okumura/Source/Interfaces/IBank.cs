using System;

using Entity.Users;

namespace Interface.Entity.Banks {
    public interface IBank {
        // Account map ( accountNumber, Account )
        public Dictionary<string, Account> accounts { get; set; }
    }
}
