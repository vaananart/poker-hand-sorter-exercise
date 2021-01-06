
## NOTE: the commented lines below are excuted command to clean and build the product from the root of the repository.
## You should be able to copy and paste these command and execute them in the commandline prompt.

#dotnet clean .\PokerHandSorterConsoleApp
Start-Process -FilePath 'dotnet' -WorkingDirectory ".\PokerHandSorterConsoleApp" -ArgumentList 'clean'

# dotnet build .\PokerHandSorterConsoleApp
Start-Process -FilePath 'dotnet' -WorkingDirectory ".\PokerHandSorterConsoleApp" -ArgumentList 'build'