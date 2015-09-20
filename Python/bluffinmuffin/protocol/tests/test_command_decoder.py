from nose.tools import assert_equal
from numpy.testing import run_module_suite

from bluffinmuffin.protocol.tests.command_factory import *


def assert_command(msg, c):
    j = json.loads(msg)
    command = CommandDecoder.decode(j)
    assert_equal(json.loads(command.encode()), j)
    assert_equal(json.loads(c.encode()), j)


def test_disconnect_command():
    assert_command(disconnect_command_json(), disconnect_command_obj())


def test_identify_command():
    assert_command(identify_command_json(), identify_command_obj())
    assert_command(identify_response_json(), identify_response_obj())


def test_create_table_command():
    assert_command(create_table_command_json(), create_table_command_obj())
    assert_command(create_table_response_json(), create_table_response_obj())


def test_join_table_command():
    assert_command(join_table_command_json(), join_table_command_obj())
    assert_command(join_table_response_json(), join_table_response_obj())


def test_leave_table_command():
    assert_command(leave_table_command_json(), leave_table_command_obj())


def test_list_table_command():
    assert_command(list_table_command_json(), list_table_command_obj())
    assert_command(list_table_response_json(), list_table_response_obj())


def test_check_compatibility_command():
    assert_command(check_compatibility_command_json(), check_compatibility_command_obj())
    assert_command(check_compatibility_response_json(), check_compatibility_response_obj())


def test_authenticate_user_command():
    assert_command(authenticate_user_command_json(), authenticate_user_command_obj())
    assert_command(authenticate_user_response_json(), authenticate_user_response_obj())


def test_check_display_exist_command():
    assert_command(check_display_exist_command_json(), check_display_exist_command_obj())
    assert_command(check_display_exist_response_json(), check_display_exist_response_obj())


def test_check_user_exist_command():
    assert_command(check_user_exist_command_json(), check_user_exist_command_obj())
    assert_command(check_user_exist_response_json(), check_user_exist_response_obj())


def test_create_user_command():
    assert_command(create_user_command_json(), create_user_command_obj())
    assert_command(create_user_response_json(), create_user_response_obj())


def test_get_user_command():
    assert_command(get_user_command_json(), get_user_command_obj())
    assert_command(get_user_response_json(), get_user_response_obj())


def test_player_sit_in_command():
    assert_command(player_sit_in_command_json(), player_sit_in_command_obj())
    assert_command(player_sit_in_response_json(), player_sit_in_response_obj())


def test_player_sit_out_command():
    assert_command(player_sit_out_command_json(), player_sit_out_command_obj())
    assert_command(player_sit_out_response_json(), player_sit_out_response_obj())


def test_bet_turn_ended_command():
    assert_command(bet_turn_ended_command_json(), bet_turn_ended_command_obj())


def test_bet_turn_started_command():
    assert_command(bet_turn_started_command_json(), bet_turn_started_command_obj())


def test_discard_round_ended_command():
    assert_command(discard_round_ended_command_json(), discard_round_ended_command_obj())


def test_discard_round_started_command():
    assert_command(discard_round_started_command_json(), discard_round_started_command_obj())


def test_game_ended_command():
    assert_command(game_ended_command_json(), game_ended_command_obj())


def test_game_started_command():
    assert_command(game_started_command_json(), game_started_command_obj())


def test_player_hole_cards_changed_command():
    assert_command(player_hole_cards_changed_command_json(), player_hole_cards_changed_command_obj())


def game_message_general_information_command():
    assert_command(game_message_general_information_command_json(), game_message_general_information_command_obj())


def test_game_message_raising_capped_command():
    assert_command(game_message_raising_capped_command_json(), game_message_raising_capped_command_obj())


def test_game_message_stud_bring_in_command():
    assert_command(game_message_stud_bring_in_command_json(), game_message_stud_bring_in_command_obj())


def test_game_message_stud_highest_hand_command():
    assert_command(game_message_stud_highest_hand_command_json(), game_message_stud_highest_hand_command_obj())


def test_game_message_player_joined_command():
    assert_command(game_message_player_joined_command_json(), game_message_player_joined_command_obj())


def test_game_message_player_left_command():
    assert_command(game_message_player_left_command_json(), game_message_player_left_command_obj())


def test_player_turn_began_command():
    assert_command(player_turn_began_command_json(), player_turn_began_command_obj())


def test_player_turn_ended_command():
    assert_command(player_turn_ended_command_json(), player_turn_ended_command_obj())


def test_player_won_pot_command():
    assert_command(player_won_pot_command_json(), player_won_pot_command_obj())


def test_seat_updated_command():
    assert_command(seat_updated_command_json(), seat_updated_command_obj())


def test_table_closed_command():
    assert_command(table_closed_command_json(), table_closed_command_obj())


def test_player_discard_action_command():
    assert_command(player_discard_action_command_json(), player_discard_action_command_obj())


def test_player_play_money_command():
    assert_command(player_play_money_command_json(), player_play_money_command_obj())


if __name__ == "__main__":
    assert_equal.__self__.maxDiff = None
    run_module_suite()
