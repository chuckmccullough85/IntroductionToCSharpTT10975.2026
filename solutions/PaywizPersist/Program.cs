using Payroll;
using PaywizUI;

// may need to adjust the path depending on the IDE and output directory (ie bin/Debug/net9.0)
var projPath = System.IO.Directory
    .GetParent(System.IO.Directory.GetCurrentDirectory())
    ?.Parent?.Parent?.FullName;
    
    
var org = OrganizationSerializer.Deserialize($@"{projPath}\PayrollData.json")
    ?? new Organization("Acme Corporation", "12-1234567");

new MainMenu(org).Display();

OrganizationSerializer.Serialize(org, $@"{projPath}\PayrollData.json");

