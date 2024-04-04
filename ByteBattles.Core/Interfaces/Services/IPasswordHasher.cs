namespace ByteBattles.Core.Interfaces.Services;

public interface IPasswordHasher
{
    string Generate(string password);
    bool Verify(string password,string encryptedPassword);
}