namespace Application.Common.Interfaces.Services;

public interface IBackupService
{
    Task SaveToCsv(string directoryPath);
    Task RestoreFromCsv(string directoryPath);
}