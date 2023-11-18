using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auswahljw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Awake()
   {
    if (m_Btn_NextCharacter != null)
	   { 
        m_Btn_NextCharacter.onClick.AddListener(NextCharacter);
       }
    if (m_Btn_PreviousCharacter != null){
        m_Btn_PreviousCharacter.onClick.AddListener(PreviousCharacter);
    }
	    
   }
   void NextCharacter()
   {

    m_CurrentCharacterID++;
    if (m_CurrentCharacterID >= m_CharacterDatabase.Length){
        m_CurrentCharacterID = 0;
    }
	    
   }
   void PreviousCharacter()
   {

        m_CurrentCharacterID--;
        if (m_CurrentCharacterID < 0)
	    {
            m_CurrentCharacterID = m_CharacterDatabase.Length-1;
        }
   }
}
