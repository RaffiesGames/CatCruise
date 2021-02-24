// Raffie made this!


#include "AnotherOne.h"

// Sets default values
AAnotherOne::AAnotherOne()
{
 	// Set this character to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AAnotherOne::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AAnotherOne::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void AAnotherOne::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}

