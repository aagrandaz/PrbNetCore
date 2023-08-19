using System.Collections.Generic;
using System.Linq;
using MyMoviePreferencesApp.Api.DTOs;
using MyMoviePreferencesApp.Api.Services;
using MyMoviePreferencesApp.Core.DTOs;
using MyMoviePreferencesApp.Core.Entities;
using MyMoviePreferencesApp.Core.Repositories;

namespace MyMoviePreferencesApp.Core.Services
{
    public class PreferenceService : IPreferenceService
    {
        private readonly IPreferenceRepository _preferenceRepository;

        public PreferenceService(IPreferenceRepository preferenceRepository)
        {
            _preferenceRepository = preferenceRepository;
        }

        public IEnumerable<PreferenceDto> GetUserPreferences(int userId)
        {
            var userPreferences = _preferenceRepository.GetUserPreferences(userId);

            var preferenceDtos = userPreferences.Select(preference => new PreferenceDto
            {
                PreferenceID = preference.PreferenceID,
                UserID = preference.UserID,
                GenreID = preference.GenreID
            }).ToList();

            return preferenceDtos;
        }
    }
}