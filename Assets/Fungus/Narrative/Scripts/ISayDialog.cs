﻿using UnityEngine;
using System.Collections;

namespace Fungus
{
    /// <summary>
    /// Display story text in a visual novel style dialog box.
    /// </summary>
    public interface ISayDialog
    {
        /// <summary>
        /// Sets the active state of the Say Dialog gameobject.
        /// </summary>
        void SetActive(bool state);

        /// <summary>
        /// Sets the active speaking character.
        /// </summary>
        /// <param name="character">The active speaking character.</param>
        /// <param name="flowchart">An optional Flowchart to use for variable substitution in the character name string.</param>
        void SetCharacter(Character character, Flowchart flowchart = null);

        /// <summary>
        /// Sets the character image to display on the Say Dialog.
        /// </summary>
        /// <param name="image">Image.</param>
        void SetCharacterImage(Sprite image);

        /// <summary>
        /// Write a line of story text to the Say Dialog.
        /// </summary>
        /// <param name="text">The text to display.</param>
        /// <param name="clearPrevious">Clear any previous text in the Say Dialog.</param>
        /// <param name="waitForInput">Wait for player input before continuing once text is written.</param>
        /// <param name="fadeWhenDone">Fade out the Say Dialog when writing and player input has finished.</param>
        /// <param name="stopVoiceover">Stop any existing voiceover audio before writing starts.</param>
        /// <param name="voiceOverClip">Voice over audio clip to play.</param>
        /// <param name="onComplete">Callback to execute when writing and player input have finished.</param>
        void Say(string text, bool clearPrevious, bool waitForInput, bool fadeWhenDone, bool stopVoiceover, AudioClip voiceOverClip, System.Action onComplete);

        /// <summary>
        /// Tell the Say Dialog to fade out once writing and player input have finished.
        /// </summary>
        bool FadeWhenDone { set; }

        /// <summary>
        /// Stop the Say Dialog while its writing text.
        /// </summary>
        void Stop();
    }
}