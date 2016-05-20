#pragma strict
	
	function startGame (){
		Application.LoadLevel(3);
	}
	
    function backToMenu (){
        Application.LoadLevel(0);
    }

    function controls (){
        Application.LoadLevel(1);
    }

    function instructions (){
        Application.LoadLevel(2);
    }
    
	function exitGame (){
		Application.Quit();
	}

