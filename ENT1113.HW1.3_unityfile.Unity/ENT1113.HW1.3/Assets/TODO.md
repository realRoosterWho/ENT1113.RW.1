# TODO

- [ ] 用实例化的方法生成AudioSource，而不是直接拖拽在Player上面，这样可以保持连续播放
  - 具体而言，是在Player上面挂载一个AudioSource，然后在代码中实例化一个AudioSource，然后把这个AudioSource的clip设置为Player上面的AudioSource的clip，然后播放这个AudioSource，这样就可以保持连续播放了。