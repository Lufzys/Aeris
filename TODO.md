### Engine Core
- [X] Basic game loop implementation
- [X] Window creation and management
- [X] Time and delta time management
- [ ] Scene management foundation

### Rendering System
- [X] SkiaSharp integration setup
- [ ] Basic drawing context creation
- [ ] Sprite rendering
- [ ] Shape drawing (rectangles, circles, lines)
- [ ] Text rendering
- [ ] Camera system
- [ ] Viewport and coordinate system

### Component System (ECS)
- [ ] Entity class implementation
- [X] Component base class
- [ ] Component manager
- [ ] System base class and manager
- [ ] Entity-component relationships
- [ ] Built-in components:
  - [ ] Transform component
  - [ ] SpriteRenderer component
  - [ ] Collider component

### Input System
- [X] Input manager setup
- [X] Keyboard input handling
- [X] Mouse input handling
- [X] Input state tracking
- [ ] Key mapping system

### Asset Management
- [X] Asset manager architecture
- [ ] Texture loading and caching
- [ ] Font loading
- [ ] Asset disposal and cleanup
- [ ] Asset hot-reloading (development)
- [ ] Supported formats:
  - [ ] PNG, JPEG textures
  - [ ] TTF fonts
  - [ ] JSON data files

### Audio System (NAudio)
- [X] NAudio integration
- [ ] Audio manager setup
- [ ] Sound effect playback
- [ ] Background music system
- [ ] Volume controls
- [ ] Audio file format support:
  - [ ] WAV files
  - [ ] MP3 files
  - [ ] OGG files

### Sprite & Animation
- [ ] Sprite batching
- [ ] Sprite animation system
- [ ] Animation controller
- [ ] Texture atlas support
- [ ] Spritesheet parsing

### Physics Integration
- [ ] Physics engine selection/integration
- [ ] Collision detection
- [ ] Rigidbody components
- [ ] Physics materials
- [ ] Triggers and collision events

### Scene Management
- [X] Scene class implementation
- [X] Scene loading/unloading
- [ ] Scene transitions
- [ ] Persistent objects across scenes
- [ ] Scene serialization

### UI Framework
- [ ] UI canvas system
- [ ] Basic UI components:
  - [ ] Button
  - [ ] Text/Label
  - [ ] Image
  - [ ] Panel
- [ ] UI event handling
- [ ] Layout systems

### Particle Systems
- [ ] Particle system architecture
- [ ] Emitter components
- [ ] Particle properties (position, velocity, color, life)
- [ ] Built-in particle effects
