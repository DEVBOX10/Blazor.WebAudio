﻿namespace KristofferStrube.Blazor.WebAudio;

/// <summary>
/// This interface represents an audio processing code that runs on the audio rendering thread.
/// It lives in the <see cref="AudioWorkletGlobalScope"/>, and the definition of the class manifests the actual audio processing.
/// </summary>
/// <remarks><see href="https://www.w3.org/TR/webaudio/#AudioWorkletProcessor">See the API definition here</see>.</remarks>
public abstract class AudioWorkletProcessor
{
    /// <summary>
    /// Gets the <see cref="AudioWorkletNode"/> that is registered from this <see cref="AudioWorkletProcessor"/>.
    /// </summary>
    public abstract AudioWorkletNode Node { get; }
}
