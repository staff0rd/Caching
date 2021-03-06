// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.Extensions.Caching.Distributed
{
    public interface IDistributedCache
    {
        void Connect();

        Task ConnectAsync();

        byte[] Get(string key);

        Task<byte[]> GetAsync(string key);

        void Set(string key, byte[] value, DistributedCacheEntryOptions options);

        Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options);

        void Refresh(string key);

        Task RefreshAsync(string key);

        void Remove(string key);

        Task RemoveAsync(string key);
    }
}