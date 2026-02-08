using UnityEngine;

public class PlayerHealth : Health
{
protected override void Die()
{
base.Die();
Debug.Log("Player died");
}
}

Health

public class EnemyHealth : Health PlayerHealth EnemyHealth
{
protected override void Die()
{
base.Die();
Debug.Log("Enemy died");
}
}