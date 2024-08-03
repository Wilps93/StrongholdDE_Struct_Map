meta:
  id: map_file
  title: Map File
  file-extension: map
  endian: le
seq:
  - id: header_id
    type: u4
  - id: radar_map_compressed_size
    type: u4
  - id: radar_map_data
    size: radar_map_compressed_size
    type: str
    encoding: ascii
  - id: num7
    type: u4
  - id: mission_text_type
    type: u4
  - id: mission_text_number
    type: u4
  - id: ansi_mission_text
    size: num7 - 8
    type: str
    encoding: ascii
  - id: next_num7
    type: u4
  - id: xplay_save_time
    type: u4
  - id: xplay_save_checksum
    type: u4
  - id: additional_num7
    type: u4
  - id: map_type
    type: u4
  - id: map_keeps
    type: u4
    repeat: expr
    repeat-expr: 5
  - id: max_players
    type: u4
  - id: next_additional_num7
    type: u4
  - id: scn_mission_type
    type: u4
  - id: scn_mission_siege_or_invasion
    type: u4
  - id: mission_lock_type
    type: u4
  - id: stand_alone_filename
    size: additional_num7 - 12
    type: str
    encoding: ascii
  - id: ach_food
    type: u2
  - id: ach_weapons
    type: u2
  - id: ach_wood
    type: u2
  - id: is_king_of_the_hill
    type: u4
  - id: is_siege_that
    type: u4
  - id: xplay_auto_save
    type: u4