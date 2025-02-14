﻿namespace HackerNewsBestStories.Api.HackerRankApi.Cache;

public interface ICacheService
{
    T? Get<T>(string key);
    void Set<T>(string key, T value, TimeSpan expiration);
}