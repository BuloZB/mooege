/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System.Text;

namespace Mooege.Net.GS.Message.Fields
{
    public class ResolvedPortalDestination
    {
        public int /* sno */ snoWorld;
        public int Field1;
        public int /* sno */ snoDestLevelArea;

        public void Parse(GameBitBuffer buffer)
        {
            snoWorld = buffer.ReadInt(32);
            Field1 = buffer.ReadInt(32);
            snoDestLevelArea = buffer.ReadInt(32);
        }

        public void Encode(GameBitBuffer buffer)
        {
            buffer.WriteInt(32, snoWorld);
            buffer.WriteInt(32, Field1);
            buffer.WriteInt(32, snoDestLevelArea);
        }

        public void AsText(StringBuilder b, int pad)
        {
            b.Append(' ', pad);
            b.AppendLine("ResolvedPortalDestination:");
            b.Append(' ', pad++);
            b.AppendLine("{");
            b.Append(' ', pad);
            b.AppendLine("snoWorld: 0x" + snoWorld.ToString("X8"));
            b.Append(' ', pad);
            b.AppendLine("Field1: 0x" + Field1.ToString("X8") + " (" + Field1 + ")");
            b.Append(' ', pad);
            b.AppendLine("snoDestLevelArea: 0x" + snoDestLevelArea.ToString("X8"));
            b.Append(' ', --pad);
            b.AppendLine("}");
        }


    }
}