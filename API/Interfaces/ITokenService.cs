﻿namespace API.Entities;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
