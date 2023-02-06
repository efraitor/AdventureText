using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Librer�a para poder acceder a los TextMeshPro
using UnityEngine.UI; //Librer�a para acceder a los componentes de la UI

public class AdventureGameController : MonoBehaviour
{
    //Con esto podemos acceder al Texto de TextMeshPro de la UI
    [SerializeField] TextMeshProUGUI textComponent; 
    
    //Referencia de tipo State (osea de la clase State), que usamos para poder acceder a las variables y m�todos del script State
    State state; //Este estado ir� cambiando conforme avanza el juego

    //Ser� el estado inicial en el que empieza el juego
    [SerializeField] State startingState;

    // Start is called before the first frame update
    void Start()
    {
        //El estado actual ser� el estado inicial del juego
        state = startingState;
        //Accedemos al componente text dentro del textComponent(StoryText) y metemos lo que haya dentro del campo storyText del estado actual
        textComponent.text = state.GetStateStory(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Hacemos la llamadad al m�todo
        ManageState();
    }

    //M�todo para manejar el cambio entre estados
    private void ManageState()
    {
        //Generamos un array de estados, donde guardamos los estados a los que podemos ir desde el estado actual en el que estamos
        var nextStates = state.GetNextStates(); // <=> State[] nextStates = state.GetNextStates();

        //Con este for conseguimos mejorar lo abajo comentado
        for (int index = 0; index < nextStates.Length; index++)
        {
            //Apha1 + index, cambiar� de n�mero que pulsar cada vez
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                //Ir� al estado cuya posici�n sea el valor de index
                state = nextStates[index];
            }
        }

        for(int i = 0; i<= 10;i++ )
        {

        }

        ////Si pulsamos la tecla 1 del teclado
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    //Del estado en el que est� pasa al siguiente estado que est� en la posici�n del array 0
        //    state = nextStates[0];
        //}
        ////Si pulsamos la tecla 2 del teclado
        //else if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    //Del estado en el que est� pasa al siguiente estado que est� en la posici�n del array 1
        //    state = nextStates[1];
        //}
        ////Si pulsamos la tecla 3 del teclado
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    //Del estado en el que est� pasa al siguiente estado que est� en la posici�n del array 2
        //    state = nextStates[2];
        //}

        //Actualizamos el texto del juego, con el del siguiente estado al que entramos
        textComponent.text = state.GetStateStory();
    }
}
