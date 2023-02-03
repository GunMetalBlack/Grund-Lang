#include <iostream>

class Entity {
    public:
    Entity() {
        this->health = 100;
    }
    int getHealth() {
        return this->health;
    }
    private:
    int health;
};

int main() {
    Entity myEntity = Entity();
    std::cout << myEntity.getHealth() << std::endl;
    std::cout << Entity.getHealth(myEntity) << std::endl;
    return 0;
}