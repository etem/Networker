﻿using System;
using System.Threading.Tasks;

namespace Networker.Common.Abstractions
{
    public interface IPacketHandler
    {
	    Task Handle(IPacketContext packetContext);
        Task Handle(byte[] packet, IPacketContext packetContext);
        Task Handle(byte[] packet, int offset, int length, IPacketContext packetContext);
    }

    public interface IPacketHandler<T>
    {
	    Task Handle(IPacketContext packetContext);
    }
}