using System;

namespace mini;

interface ITaxPayer
{
    int PayTax();
}

interface IHideable
{
    void Hide(string enemyName);
}