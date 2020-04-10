#version 330 core

out vec4 FragColor;

in vec3 ourColor;
in vec2 texCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;

uniform float opacity;

void main()
{
	// Permet de tester les coordonnées de la textures. Et donc de les debugguer si besoin
	// En bas à gauche, ça doit être noir (0, 0).
	// Le vert sur le bord gauche sur l'axe vertical (y)
	// Le rouge sur le bord du bas sur l'axe horizontal (x).
	// Et l'interpolation fera vers du jaune sur le reste toute seule
	//FragColor = vec4(texCoord, 0.0f, 1.0f);

	// Affiche la première texture seule
	//FragColor = texture(texture1, texCoord);

	// Affiche la seconde texture seule
	//FragColor = texture(texture2, texCoord);

	// Affiche les 2 textures mélangées
	FragColor = mix(texture(texture1, texCoord), texture(texture2, texCoord), opacity);
}