using Microsoft.EntityFrameworkCore.Migrations;

namespace NajmSound.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
GO
INSERT [dbo].[AspNetUsers] ([Id], [Name], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6D36158C-6536-451C-90DE-85A498CD1ABB', N'Admin', N'Admin@sound.com', N'ADMIN@SOUND.COM', N'Admin@sound.com', N'ADMIN@SOUND.COM', 1, NULL, NULL, NULL, NULL, 0, 0, NULL, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Artists] ON 
GO
INSERT [dbo].[Artists] ([Id], [Name], [UserId], [Info], [InstgramUri], [Genre], [JoinDate]) VALUES (2, N'Ed Sheeran ', NULL, N'Edward Christopher Sheeran MBE is an English singer-songwriter, record producer, musician, and actor. Sheeran has sold more than 150 million records worldwide, making him one of the world''s best-selling music artists', N'https://www.instagram.com/teddysphotos/', 1, CAST(N'2021-09-01T12:11:21.6500000' AS DateTime2))
GO
INSERT [dbo].[Artists] ([Id], [Name], [UserId], [Info], [InstgramUri], [Genre], [JoinDate]) VALUES (3, N'Billie Eilish', NULL, N'Billie Eilish Pirate Baird O''Connell is an American singer and songwriter. She first gained public attention in 2015 with her debut single “Ocean Eyes”, which was subsequently released by Darkroom, a subsidiary of Interscope Records', N'https://www.instagram.com/billieeilish/', 1, CAST(N'2021-09-03T12:11:21.6500000' AS DateTime2))
GO
INSERT [dbo].[Artists] ([Id], [Name], [UserId], [Info], [InstgramUri], [Genre], [JoinDate]) VALUES (4, N'Jay-Z', NULL, N'Shawn Corey Carter, known professionally as Jay-Z, is an American rapper, songwriter, record executive, businessman, and media proprietor', NULL, 3, CAST(N'2021-09-04T12:11:21.6500000' AS DateTime2))
GO
INSERT [dbo].[Artists] ([Id], [Name], [UserId], [Info], [InstgramUri], [Genre], [JoinDate]) VALUES (5, N'Cardi B', NULL, N'Belcalis Marlenis Almánzar, known professionally as Cardi B, is an American rapper. Born and raised in New York City, she became an Internet celebrity by achieving popularity on Vine and Instagram.', N'https://www.instagram.com/iamcardib/', 3, CAST(N'2021-09-05T12:11:21.6500000' AS DateTime2))
GO
INSERT [dbo].[Artists] ([Id], [Name], [UserId], [Info], [InstgramUri], [Genre], [JoinDate]) VALUES (6, N'BTS', NULL, N'BTS, also known as the Bangtan Boys, is a seven-member South Korean boy band that was formed in 2010 and debuted in 2013 under Big Hit Entertainment. The septet—composed of Jin, Suga, J-Hope, RM, Jimin, V, and Jungkook—co-writes and co-produces much of their own output', N'https://www.instagram.com/bts.bighitofficial/', 2, CAST(N'2021-09-05T19:11:21.6500000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Artists] OFF
GO
SET IDENTITY_INSERT [dbo].[LikedArtists] ON 
GO
INSERT [dbo].[LikedArtists] ([Id], [ArtistId], [UserId]) VALUES (1, 2, N'6D36158C-6536-451C-90DE-85A498CD1ABB')
GO
INSERT [dbo].[LikedArtists] ([Id], [ArtistId], [UserId]) VALUES (2, 5, N'6D36158C-6536-451C-90DE-85A498CD1ABB')
GO
SET IDENTITY_INSERT [dbo].[LikedArtists] OFF
GO
SET IDENTITY_INSERT [dbo].[Albums] ON 
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (2, N'x', 2, N'× is the second studio album by English singer-songwriter, Ed Sheeran. It was released on 20 June 2014 in Australia and New Zealand, and worldwide on 23 June through Asylum Records and Atlantic Records. The album received positive reviews from music critics', N'2014')
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (3, N'No. 6 Collaborations Project', 2, N'No.6 Collaborations Project is the fourth studio album and second collaboration project by English singer-songwriter Ed Sheeran. It was released on 12 July 2019 by Asylum Records and Atlantic Records.', N'2019')
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (4, N'Happier Than Ever', 3, N'Happier Than Ever is the second studio album by American singer Billie Eilish. It was released on July 30, 2021, by Darkroom and Interscope Records. Eilish wrote the album with her frequent collaborator, her brother Finneas O''Connell, who produced the album himself.', N'2021')
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (5, N'The Blue Print', 4, N'The Blueprint is the sixth studio album by American rapper Jay-Z. It was released on September 11, 2001, by Roc-A-Fella Records and Def Jam Recordings. Its release was set a week earlier than initially planned in order to combat bootlegging', N'2003')
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (6, N'Invasion of Privacy', 5, N'Invasion of Privacy is the debut studio album by American rapper Cardi B. It was released on April 6, 2018, by Atlantic Records. Primarily a hip hop record, Invasion of Privacy also comprises trap, Latin and R&B', N'2018')
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (7, N'Gangsta Bitch Music, Vol. 1', 5, N'Gangsta Bitch Music, Vol. 1 is the debut mixtape by American rapper Cardi B. It was released on March 7, 2016, by KSR. Cardi B has been sued by a model for allegedly using his image on the mixtape''s cover artwork without his permission', N'2016')
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (10, N'Map Of The Soul: 7', 6, N'Map of the Soul: 7 is the fourth Korean-language studio album by South Korean boy band BTS. The album was released on February 21, 2020, by Big Hit Entertainment. It is the follow-up to their 2019 extended play Map of the Soul: Persona, with five of its songs appearing on the album', N'2020')
GO
INSERT [dbo].[Albums] ([Id], [Name], [ArtistId], [About], [ReleaseYear]) VALUES (11, N'Wings', 6, N'Wings is the second Korean studio album by South Korean boy band BTS. The album was released on October 10, 2016, by Big Hit Entertainment. It is available in four versions and contains fifteen tracks, with “Blood Sweat & Tears“ serving as its lead single.', N'2016')
GO
SET IDENTITY_INSERT [dbo].[Albums] OFF
GO
SET IDENTITY_INSERT [dbo].[Songs] ON 
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (1, N'Thinking Out Loud', 1, 2, 2, N'Sheeran wrote this love song about his girlfriend, Athina Andrelos, who works for English celebrity chef Jamie Oliver. ... My friend Amy who I wrote some songs with, came up to my house to listen to the album and we were meant to go out for dinner that night.', N'4:46', N'2016')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (2, N'Photograph', 1, 2, 2, N'“Photograph” is a song by English singer-songwriter Ed Sheeran from his second studio album, ×. Sheeran wrote the song with Snow Patrol member Johnny McDaid, who had a piano loop from which the composition developed.', N'4:25', N'2014')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (4, N'Beatiful People', 1, 2, 3, N'“Beautiful People” is a song by English singer-songwriter Ed Sheeran featuring American singer Khalid. Asylum Records UK released it on 28 June 2019, as the third single from his fourth studio album, No.6', N'3:48', N'2019')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (5, N'South Of The Boarder', 1, 2, 3, N'“South of the Border” is a song by English singer-songwriter Ed Sheeran featuring Cuban-American singer Camila Cabello and Dominican-American rapper Cardi B. It was released as the seventh single from Sheeran''s fourth studio album, No.6 Collaborations Project (2019).The song was written by Sheeran, Cabello, Cardi B, Steve Mac, Fred Gibson and Jordan Thorpe, and produced by Sheeran, Mac and Gibson.It reached the top ten in eight countries and is certified Gold or higher in eleven countries', N'3:24', N'2019')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (6, N'Getting Older', 1, 3, 4, N'“Getting Older” is the vulnerable introductory track to Billie Eilish’s sophomore album, Happier Than Ever.

Over a delicate plucking synth beat, Billie covers various sensitive subjects including stalkers, a growing sense of responsibility, personal revelations, and past trauma. Billie varies the use of her voice, with a soft, quiet tone and yodeling-like vocals.

Prior to the album’s release, the song’s lyrics were teased in Billie’s cover of the July 2021 issue of Rolling Stone Magazine.', N'4:53', N'2021')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (7, N'My Future', 1, 3, 4, N'“my future” portrays Billie reflecting on her past and her future, and her change in style from a more melancholic sound, towards a happier, more optimistic one.

“my future” is Billie Eilish’s first single since the release of her acclaimed February 2020 James Bond theme song “No Time To Die.” After almost a month away from social media, Eilish returned on July 24, 2020, to announce the track and its release date. The cover art and exact time of release for the song were announced later on July 28, 2020.

On July 29, a day before the release date, a snippet of the song was published on Billie’s Instagram page.

The track was released alongside a music video on July 30, 2020.', N'3:50', N'2020')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (8, N'NDA', 1, 3, 4, N'On “NDA,” Billie details her struggles with fame, particularly the trials she has to face to keep romances under the radar by having those around her sign an NDA, or a Non-Disclosure Agreement. As the track progresses, Eilish can’t help but wish her life were different and didn’t require her to navigate the obstacles she faces.

The song also plays on the titles and theme of several other tracks on Happier Than Ever, including “Getting Older,” “I Didn’t Change My Number,” “my future,” and “Therefore I Am.”', N'3:16', N'2021')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (9, N'Your Power', 1, 3, 4, N'“Your Power” is the third single from Billie Eilish’s second studio album, Happier Than Ever. The song recounts an abusive relationship and how it affected her. Fan theories claimed that the song was about Q, AKA 7: AMP, who Billie dated back when she was only 16. However, during an interview with Esquire in May 2021, she confirmed that the song isn’t about a specific person, while also expressing her hope that this song can spark change and reflection.

The song was first teased on April 27, 2021, when Billie announced that a single would be released on the morning of April 29. On April 28, Billie revealed that this would be the single and announced its accompanying music video.', N'4:08', N'2021')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (10, N'Take Over', 2, 4, 5, N'Jay Z’s diss song aimed at Mobb Deep and Nas. The song is better remembered for its Nas diss as it catalyzed the long-running and epic Jay-Z/Nas beef.

The first 2 verses were debuted live at NYC radio station Hot 97’s Summer Jam concert, complete with a childhood picture of Mobb Deep’s Prodigy in 80’s MJ-inspired dance gear.

The brilliant beat is sampled from “5 to 1” by The Doors, and KRS-One’s “Sound of Da Police.” “Takeover” was the first song Young Guru ever mixed for Jay-Z, beginning a long and fruitful relationship.', N'5:13', N'2021')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (12, N'Filter', 3, 6, 10, N'The colorful Latin-pop infused track “Filter” is Jimin’s personal solo song for BTS'' fourth Korean full-length album. With the concept created by Jimin himself, the song is accompanied by a midi pad beat and an acoustic finger-picked guitar rhythm.

In this song Jimin talks about his duality as an artist, as well as the confidence he has in his ability to efficiently showcase different sides of him at one’s demand, as if he was a photo filter.', N'3:14', N'2020')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (13, N'Friends', 3, 6, 10, N'“친구” (Friends) is a song by Jimin and V of BTS. It was released on February 21, 2020, and appears as the fifteenth track in their fourth studio album Map of the Soul: 7.', N'3:57', N'2019')
GO
INSERT [dbo].[Songs] ([Id], [Name], [Genre], [ArtistId], [AlbumId], [About], [Length], [ReleaseYear]) VALUES (14, N'Outer Ego', 3, 6, 10, N'“Outro: Ego” is a song by J-Hope of BTS. It was released on February 2, 2020 as the second comeback trailer and appears as the nineteenth track in their fourth studio album Map of the Soul: 7.', N'3:24', N'2020')
GO
SET IDENTITY_INSERT [dbo].[Songs] OFF
GO
SET IDENTITY_INSERT [dbo].[LikedSongs] ON 
GO
INSERT [dbo].[LikedSongs] ([Id], [SongId], [UserId]) VALUES (1, 1, N'6D36158C-6536-451C-90DE-85A498CD1ABB')
GO
INSERT [dbo].[LikedSongs] ([Id], [SongId], [UserId]) VALUES (2, 5, N'6D36158C-6536-451C-90DE-85A498CD1ABB')
GO
INSERT [dbo].[LikedSongs] ([Id], [SongId], [UserId]) VALUES (3, 9, N'6D36158C-6536-451C-90DE-85A498CD1ABB')
GO
INSERT [dbo].[LikedSongs] ([Id], [SongId], [UserId]) VALUES (4, 10, N'6D36158C-6536-451C-90DE-85A498CD1ABB')
GO
INSERT [dbo].[LikedSongs] ([Id], [SongId], [UserId]) VALUES (5, 14, N'6D36158C-6536-451C-90DE-85A498CD1ABB')
GO
SET IDENTITY_INSERT [dbo].[LikedSongs] OFF
GO


");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
