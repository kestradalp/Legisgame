using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManage : MonoBehaviour
{
    public GameObject transition;
    public Text levelCleared;
    public Text preg;
    public Text verd;
    public Text fals;
    System.Random rnd = new System.Random();
    public int numeroAleatorio = -1;
    public int numeal = -1;
    void Start()
    {
        // Random rnd = new Random();
        if (numeroAleatorio == -1 ){
            numeroAleatorio = rnd.Next(0, 10);
            numeal = numeroAleatorio;
        }
    }
    private void Update(){

        
        AllFruitCollected();
    }
    public void AllFruitCollected(){
        if(transform.childCount==0){
            Debug.Log("No quedan frutas");
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene",1);
            
        }
        
        
        List<string> listaDePreguntas = new List<string>()
        {
            "¿Cuál es una función de las autoridades reguladoras en el contexto del derecho informático?",
            "¿Cuál es un desafío principal en la recopilación de estadísticas sobre delitos informáticos?",
            "¿En el contexto de protección de datos personales, ¿qué principio es fundamental?",
            "¿Qué tipo de ciberdelincuente suele estar motivado por causas políticas o sociales?",
            "¿Cuál es un reto importante en la investigación de delitos informáticos?",
            "¿Qué papel juegan las autoridades reguladoras en la legislación informática?",
            "¿Cuál es un impacto social directo de los delitos informáticos?",
            "¿Qué protege el derecho a la privacidad en el ámbito de la informática?",
            "¿Qué tipo de delito informático implica la producción y distribución de material de abuso sexual infantil?",
            "¿Qué estrategia es clave para la prevención de delitos informáticos?"
        };
        List<string> listaOpcionVerdadera = new List<string>()
        {
            "A) Supervisar el cumplimiento de la legislación informática.",
            "A) Subnotificación de incidentes.",
            "A) Transparencia y responsabilidad de los recolectores de datos.",
            "A) Hacktivistas.",
            "A) Rastreo y manejo de evidencia digital.",
            "A) Supervisar el cumplimiento de la legislación de protección de datos.",
            "A) Pérdida de confianza en las instituciones digitales.",
            "A) El control sobre la recopilación y uso de datos personales.",
            "A) Explotación de menores en línea.",
            "A) Educación y concienciación sobre ciberseguridad."
        };
        List<string> listaOpcionFalsa = new List<string>()
        {
            "B) Proveer servicios de almacenamiento en la nube",
            "B) Dificultad en la traducción de datos",
            "B) Uso ilimitado de datos personales.",
            "B) Agentes patrocinados por el enemigo del Estado.",
            "B) Obtener financiamiento para investigaciones.",
            "B) Proveer servicios de internet.",
            "B) Incremento de la ciberdelincuencia.",
            "B) La seguridad de las transacciones financieras.",
            "B) Phishing.",
            "B) Exclusión de servicios en línea"
        };
        string preguntaSeleccionada = listaDePreguntas[numeroAleatorio];
        string respuestaVerdadera = listaOpcionVerdadera[numeroAleatorio];
        string respuestaFalsa = listaOpcionFalsa[numeroAleatorio];

        preg.gameObject.SetActive(true);
        verd.gameObject.SetActive(true);
        fals.gameObject.SetActive(true);
        
        if (preg != null && verd != null && fals != null ) {
            preg.text = preguntaSeleccionada;
            verd.text = respuestaVerdadera;
            fals.text = respuestaFalsa;
        }
        
        
    }
    void ChangeScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}

