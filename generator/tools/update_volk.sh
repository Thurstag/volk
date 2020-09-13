#!/bin/bash

# Check arguments count
if [ "$#" -ne 2 ]; then
    echo "Illegal number of arguments" 
    echo "Usage: update_volk.sh [GENERATOR_PROGRAM_PATH] [VOLK_LIBRARY_PATH]"
    exit 1
fi

# Check generator program & volk folder
if [ ! -x "$1" ]; then
    echo "Generator program ($1) doesn't exist"
    exit 1
fi
if [ ! -d "$2" ]; then
    echo "Volk library folder ($2) doesn't exist"
    exit 1
fi

# Execute generator
$1

# Move files
mv "Bitmasks.cs" "$2/Vulkan/Types/Bitmasks.cs"
mv "Enumerations.cs" "$2/Vulkan/Types/Enumerations.cs"
mv "Structures.cs" "$2/Vulkan/Types/Structures.cs"
mv "Unions.cs" "$2/Vulkan/Types/Unions.cs"
mv "CommandTable.cs" "$2/Vulkan/CommandTable.cs"
mv "Commands.cs" "$2/Vulkan/Commands.cs"
mv "Constants.cs" "$2/Vulkan/Constants.cs"
mv "DeviceCommandTable.cs" "$2/Vulkan/DeviceCommandTable.cs"
mv "DeviceFunctions.cs" "$2/DeviceFunctions.cs"
mv "InstanceFunctions.cs" "$2/InstanceFunctions.cs"

echo "Generated files were moved into $2"