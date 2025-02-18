// Operating on binary numbers at the bit level

using FunWithBitwiseOperations;

ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;

namespace FunWithBitwiseOperations
{
  [Flags]
  public enum ContactPreferenceEnum
  {
    None = 1,
    Email = 2,
    Phone = 4,
    Ponyexpress = 6,
  }
}


// TODO: review this