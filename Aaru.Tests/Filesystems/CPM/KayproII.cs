// /***************************************************************************
// Aaru Data Preservation Suite
// ----------------------------------------------------------------------------
//
// Author(s)      : Natalia Portillo <claunia@claunia.com>
//
// Component      : Aaru unit testing.
//
// --[ License ] --------------------------------------------------------------
//
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
//
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// ----------------------------------------------------------------------------
// Copyright © 2011-2021 Natalia Portillo
// ****************************************************************************/

using System.IO;
using Aaru.CommonTypes;
using Aaru.CommonTypes.Interfaces;
using Aaru.CommonTypes.Structs;
using NUnit.Framework;

namespace Aaru.Tests.Filesystems.CPM
{
    [TestFixture]
    public class KayproII : ReadOnlyFilesystemTest
    {
        public KayproII() : base("CP/M") {}

        public override string DataFolder => Path.Combine(Consts.TEST_FILES_ROOT, "Filesystems", "CPM", "Kaypro II");

        public override IFilesystem Plugin     => new Aaru.Filesystems.CPM();
        public override bool        Partitions => false;

        public override FileSystemTest[] Tests => new[]
        {
            new FileSystemTest
            {
                TestFile    = "filename.imd",
                MediaType   = MediaType.Unknown,
                Sectors     = 400,
                SectorSize  = 512,
                Bootable    = true,
                Clusters    = 194,
                ClusterSize = 1024,
                Info = new Aaru.CommonTypes.Structs.FileSystemInfo(){Blocks = 195,
                    FilenameLength                                          = 11,
                    Files                                                   = 38,
                    FreeBlocks                                              = 157,
            PluginId                                                        = Plugin.Id,
            Type                                                            = "CP/M filesystem"}
            },
            new FileSystemTest
            {
                TestFile    = "files.imd",
                MediaType   = MediaType.Unknown,
                Sectors     = 400,
                SectorSize  = 512,
                Bootable    = true,
                Clusters    = 194,
                ClusterSize = 1024,
                Info = new Aaru.CommonTypes.Structs.FileSystemInfo(){Blocks = 195,
                    FilenameLength                                          = 11,
                    Files                                                   = 38,
                    FreeBlocks                                              = 157,
                    PluginId                                                = Plugin.Id,
                    Type                                                    = "CP/M filesystem"}
            }
        };
    }
}