using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SA_Unit : MonoBehaviour
{

    public SPUM_Prefabs _spumPref;

    public enum UnitState
    {

        idle,

        run,

        attack,

        stun,

        skill,

        death

    }

    public UnitState _unitState = UnitState.idle;

    public SA_Unit _target;

    public float _unitHP;

    public float _unitMS;

    public float _unitFR;

    public float _unitAT;

    public float _unitAS;

    public float _unitAR;

    public Vector2 _tempDis;

    public Vector2 _dirVec;

    public float _findTimer;

    public float _attackTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckState();

    }

    void SetInitState()
    {
        _unitState = UnitState.idle;
    }

    void CheckState()
    {
        switch (_unitState)
        {
            case UnitState.idle:
                FindTarget();
                break;

            case UnitState.run:
                FindTarget();
                DoMove();
                break;
            case UnitState.attack:
                CheckAttack();
                break;

            case UnitState.stun:
                break;
            case UnitState.skill:
                break;
            case UnitState.death:
                break;
        }
    }

    void SetState(UnitState state)
    {
        _unitState = state;
        switch (_unitState)
        {
            case UnitState.idle:
                _spumPref.PlayAnimation("0_idle");
                break;
            case UnitState.run:
                _spumPref.PlayAnimation("1_Run");
                break;
            case UnitState.attack:
                _spumPref.PlayAnimation("0_idle");
                Debug.Log("�ʰ� ������");
                //_spumPref.PlayAnimation("2_Attack_Normal");
                break;

            case UnitState.stun:
                _spumPref.PlayAnimation("3_Debuff_Stun");
                break;
            case UnitState.skill:
                _spumPref.PlayAnimation("5_Skill_Normal");
                break;
            case UnitState.death:
                _spumPref.PlayAnimation("4_Death");
                break;
        }
    }



    void FindTarget()
    {
        _findTimer += Time.deltaTime;
        if (_findTimer > SoonsoonData.Instance.SAM._findTimer)
        {
            _target = SoonsoonData.Instance.SAM.GetTarget(this);
            if (_target != null) SetState(UnitState.run);
            else SetState(UnitState.idle);
            _findTimer = 0;
        }

    }

    void DoMove()
    {
        if (!CheckTarget()) return;
        CheckDistance();


        _dirVec = _tempDis.normalized;
        SetDirection();
        transform.position += (Vector3)_dirVec * _unitMS * Time.deltaTime;

    }

    bool CheckDistance() //���ݹ��� ���� ���� �ȵ����� Ÿ�ٿ��� �ٰ����� �ڵ�
    {

        _tempDis = (Vector2)(_target.transform.localPosition - transform.position);

        float tDis = _tempDis.sqrMagnitude;

        if (tDis <= _unitAR*_unitAR)
        {
            SetState(UnitState.attack); //�� �� �ڲ� ���ѹݺ�?
            return true;
        } 
        else
        {
            if (!CheckTarget()) SetState(UnitState.idle);
            else SetState(UnitState.run);

            return false;
        }
    }

    void CheckAttack()
    {
        if (!CheckTarget()) return;

        if (!CheckDistance()) return; //���⼭ üũ���潺�� �Ѿ�� attack�κй��ѹݺ�

        _attackTimer += Time.deltaTime;
        if(_attackTimer > _unitAS )
        {
            DoAttack();
            _attackTimer = 0;
        }
    }

    void DoAttack()
    {
        Debug.Log("�ִϸ��̼ǰ��� ���ۺκ�");
        _spumPref.PlayAnimation("2_Attack_Normal");

    }

    void SetDirection()
    {
        if(_dirVec.x >= 0 )
        {
            _spumPref._anim.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            _spumPref._anim.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    bool CheckTarget()
    {
        bool value = true;
        if (_target == null) return false;
        if (_target._unitState == UnitState.death) return false;
        if (!_target.gameObject.activeInHierarchy) return false;
        if(!value)
        {
            SetState(UnitState.idle);
        }

        return value;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tTag = "";
        switch(gameObject.tag)
        {
            case "P1": tTag = "P2";
                break;

            case "P2": tTag = "P1";
                break;
        }

        if(collision.gameObject.CompareTag(tTag))
        {
            Debug.Log("with Target");
        }
        else if(collision.gameObject.CompareTag(gameObject.tag))
        {
            Debug.Log("Stop");
            SetState(UnitState.idle);
        }
    }

}
