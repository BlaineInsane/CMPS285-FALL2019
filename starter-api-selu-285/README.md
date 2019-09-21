# starter-api-selu-285
# Big thanks to Matthew Puneky for offering a starting template for an API.

# DataContext connection string =
"Server=localhost\\SQLEXPRESS;Database=DegreeProgressTracker;Trusted_Connection=True;ConnectRetryCount=0;"

# Fixing database merge conflicts
	-All info pulled from this url: https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/teams?redirectedfrom=MSDN
	1) Ensure any pending model changes in your local code base have been written to a migration. This step ensures you don’t 
	   miss any legitimate changes when it comes time to generate the blank migration.
	2) Sync with source control.
	3) Run Update-Database to apply any new migrations that other developers have checked in. Note: if you don’t get any warnings 
	   from the Update-Database command then there were no new migrations from other developers and there is no need to perform any 
	   further merging.
	4) Run Add-Migration <pick_a_name> –IgnoreChanges (for example, Add-Migration Merge –IgnoreChanges). This generates a migration 
	   with all the metadata (including a snapshot of the current model) but will ignore any changes it detects when comparing the 
	   current model to the snapshot in the last migrations (meaning you get a blank Up and Down method).
	5) Continue developing, or submit to source control.