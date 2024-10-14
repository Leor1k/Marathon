INSERT INTO [dbo].[Position] ([PositionId], [PositionName], [PositionDescription], [PayPeriod], [PayRate]) VALUES(N'1', N'Helpdesk Advisor', N'Works on the helpdesk ', N'H', N'$'),
(N'2', N'Administrative Clerk', N'Provides administrative support', N'H', N'$'),
(N'3', N'HR Clerk', N'Provides support to the Market', N'H', N'$'),
(N'4', N'Finance Clerk', N'Provides support to the Finan', N'H', N'$'),
(N'5', N'Marketing Assistant', N'Provides support to the Market', N'H', N'$'),
(N'6', N'Social Media Assistant', N' Provides support to the Socia', N'H', N'$'),
(N'7', N'Assistant', N'Works  in any number of areas', N'H', N'$'),
(N'8', N'Workforce Support', N' Provides support to the Workflow', N'H', N'$'),
(N'9', N'CEO', N' Chief Executive Officer', N'Y', N'$'),
(N'10', N'Volunteer Coordinator', N' Coordinates  recruitment', N'H', N'$'),
(N'11', N'Sponsorship Coordinator', N'Identifies, develops and main', N'Y', N'$'),
(N'13', N'Social Media Coordinator', N'Manages content across social', N'Y', N'$'),
(N'14', N'Operations Manager', N'Oversees all logistical aspects', N'Y', N'$'),
(N'16', N'IT Manager', N'Oversees the plannin', N'Y', N'$'),
(N'19', N'Administrative Manager', N' Oversees the administrative flow', N'Y', N'$'),
(N'20', N'HR Manager', N'Manages the recruitment, reted', N'Y', N'$'),
(N'21', N'Finance Manager', N'esponsible for the financial', N'Y', N'$'),
(N'23', N'Workforce Manager', N'Responsible for coordinating', N'Y', N'$');
INSERT INTO [dbo].[Role] ([RoleId], [RoleName]) VALUES (N'R', N'Runner'),
(N'C', N'Cordinator'),
(N'A', N'Administrator')
INSERT INTO [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'a.adkin@dayrep.net', N'lsFMlG3KMWuWhZdnahQZqcSzkGVm4nFieXbmfRctXd6VuFFeLXRbnCozCmsQupgd', N'AHMAD', N'ADKIN', N'R'),
(N'a.aldrich@gmail.com', N'PA0wmMwgqKqYZl+sHwXyFcOGFSTC59MRWcZtuqJmMn8qujZJHsLOMOzNgEXy5dSS', N'AARON', N'ALDRICH', N'R'),
(N'a.allison@gmail.com', N'WQZJJ7M4owQHtDr416eZseY9cn70MYa4u2AlQOFW3ccgXmb0zFOBLyQrfp48DJc0', N'ALPHONSO', N'ALLISON', N'R'),
(N'a.arias@gmail.com', N'AWca2IylBaw9LVB71nSh9Ma3hhjoEQsSvdUEb1Cy9Z5XVQpvOne/vdnnXmmTQf6U', N'ANTONIO', N'ARIAS', N'R'),
(N'a.ashton@saucedout.com', N'k1EDYtUNPv1ZFUObFKSpgoAkhQ5A15y90xT0Z4owWHNHUvoCF3ZH2uSReLDuDIRG', N'ALFREDA', N'ASHTON', N'R'),
(N'a.auber@ew.net', N'bVy3/29iFgM5eqA3D7dPLHBY1NwDvbdJsx0CMyZYHjm3KIacLWhMiTDyvudEB3jG', N'ARTHUR', N'AUBER', N'R'),
(N'a.barbosa@hotmail.com', N'FtmMWBdW4sgG07w27Gwc0sJJupdRNJJbmTGRRxX8eKU59iR9BN7C9iiwisOa791X', N'ANGUS', N'BARBOSA', N'R'),
(N'a.beaulieu@hotmail.com', N'W2aCwstNmitXh+1pTRY7FoKjNf596urREANdNVuryheySftBKvhuweR9+WPXpH+e', N'ANTON', N'BEAULIEU', N'R'),
(N'a.bitsuie@ramoz.com', N'YEd4/jVPlBMM/l6WpADK7Bt/F/akftC9eVH6MgE8KoECWz5H5mG6ekDj4jtnroqx', N'APRIL', N'BITSUIE', N'R');
INSERT INTO [dbo].[Country] ([CountryCode], [CountryName], [CountyFlag]) VALUES (643, N'Россия', N'flag_russia'),
(826, N'Великобритания ', N'flag_united_kingdom'),
(724, N'Испания', N'flag_spain'),
(392, N'Япония', N'flag_japan'),
(76, N'Бразилия', N'flag_brazil');
INSERT INTO [dbo].[Staff] ([StaffId], [FirstName], [LastName], [DateOfBirth], [Gender], [PositionId], [Email]) VALUES (N'1', N'LAKISHA ', N' TOMBLIN', N'1961-08-06', N'F', N'2', N'l_tomblin@nnl.com'),
(N'2', N'KRIS', N'SWEELY', N'1980-12-24', N'M', N'3', N'k_sweely@yahoo.com'),
(N'3', N'ELSIE', N'ESTELL', N'1974-07-07', N'F', N'8', N'elsie.estell@rrg.net'),
(N'4', N'TYRELL', N'ROSENBERG', N'1965-08-02', N'M', N'6', N'tyrell_rosenberg@hotmail.com'),
(N'5', N'MADELYN ', N' HOOVER', N'1962-12-04', N'F', N'1', N'madelyn_hoover@@hotmail.com'),
(N'6', N'KENETH ', N'PARHAM', N'1967-03-30', N'M', N'2', N'k_parham@live.com'),
(N'7', N'LYLE ', N'MALLORY', N'1989-07-06', N'M', N'8', N'l_mallory@live.com'),
(N'8', N'CLIFTON ', N'FIGUEROA', N'1956-03-23', N'M', N'6', N'c_figueroa@live.com'),
(N'9', N'MOHAMMAD', N'RICHEY', N'1995-07-01', N'M', N'2', N'mohammad_richey@jcl.net'),
(N'10', N'WINIFRED ', N' DUNCAN', N'1968-10-20', N'F', N'11', N'7w_duncan@hotmail.com'),
(N'11', N'VERNITA ', N' SEABORN', N'1993-10-13', N'F', N'19', N'6v_seaborn@gmail.com'),
(N'12', N'LENORA', N'HIGGINS', N'1997-06-29', N'F', N'3', N'l_higgins@msv.org'),
(N'13', N'DON ', N'RUSS', N'1971-10-13', N'M', N'4', N'don_russ@jcl.net'),
(N'14', N'THADDEUS ', N'STALEY', N'1992-02-13', N'M', N'7', N't_staley@nnl.com'),
(N'15', N'WILFORD ', N'RIVERA', N'1978-09-21', N'M', N'1', N'wilford.rivera@gmail.com'),
(N'16', N'LANCE', N'BEYER', N'1990-09-30', N'M', N'5', N'l_beyer@rnl.com'),
(N'17', N'LASHANDA', N'SNOWDEN', N'1983-06-28', N'F', N'8', N'lashanda.snowden@rrg.net'),
(N'18', N'GLORY ', N'FELDER', N'1963-11-18', N'F', N'3', N'glory.felder@@hotmail.com'),
(N'19', N'ESTELLA ', N'BLALOCK', N'1951-10-17', N'F', N'7', N'e_blalock@@ccf.org'),
(N'20', N'TRAVIS ', N' RAMOS', N'1983-04-21', N'M', N'1', N'travis_ramos@hotmail.com'),
(N'21', N'ILA ', N'THOMPSON', N'1979-05-17', N'F', N'2', N'i_thompson@yahoo.com'),
(N'22', N'LORRAINE', N'MCKEE', N'1973-10-11', N'F', N'6', N'l_mckee@hotmail.com'),
(N'23', N'SHELLIE ', N'MONTANO', N'1974-09-19', N'F', N'1', N'shellie_montano@hotmail.com'),
(N'24', N'ERVIN ', N' LAWRENCE', N'1984-12-20', N'M', N'8', N'ervin_lawrence@hotmail.com'),
(N'25', N'GOLDA ', N' GRANGER', N'1982-04-28', N'F', N'8', N'g_granger@msv.org'),
(N'26', N'KING', N'MERCADO', N'1952-11-26', N'M', N'13', N'7k_mercado@@hotmail.com'),
(N'27', N'GERARDO ', N' BOWSER', N'1953-08-19', N'M', N'2', N'gerardo_bowser@hotmail.com'),
(N'28', N'KARIN ', N' MCCARTY', N'1985-10-17', N'F', N'3', N'k_mccarty@gmail.com'),
(N'29', N'MAYRA ', N' CALLAHAN', N'1979-08-07', N'F', N'6', N'm_callahan@live.com'),
(N'30', N'CALLAN', N'MCCONNELL', N'1958-12-13', N'M', N'8', N'callan.mcconnell@@gmail.com'),
(N'31', N'CLAYTON ', N' MARKS', N'1988-03-08', N'M', N'5', N'c_marks@nnl.com'),
(N'32', N'TRACY ', N' CUMMINGS', N'1991-01-07', N'F', N'4', N'tracy.cummings@gmail.com'),
(N'33', N'NELSON ', N'CASEY', N'1986-06-18', N'M', N'8', N'n_casey@hr.org'),
(N'34', N'STAN ', N' STOVALL', N'1960-10-07', N'M', N'6', N's_stovall@gmail.com'),
(N'35', N'EARLENE', N'HOGAN', N'1964-02-27', N'F', N'8', N'e_hogan@gmail.com'),
(N'36', N'WAYNE', N'ROSARIO', N'1953-06-20', N'M', N'5', N'w_rosario@gmail.com'),
(N'37', N'AUTUMN ', N' MCCALL', N'1965-03-11', N'F', N'3', N'autumn.mccall@rrg.net'),
(N'38', N'PRINCESS ', N'CATT', N'1970-06-21', N'F', N'8', N'p_catt@hotmail.com'),
(N'39', N'SIBYL ', N'TAGALA', N'1998-05-21', N'F', N'1', N'sibyl.tagala@hotmail.com'),
(N'40', N'MILAGROS ', N'BUSCH', N'1965-12-20', N'F', N'8', N'milagros_busch@jcl.net'),
(N'41', N'DONNIE ', N'JENNINGS', N'1969-10-15', N'F', N'1', N'd_jennings@@msv.org'),
(N'42', N'OTIS ', N' ENRIQUEZ', N'1986-01-11', N'M', N'11', N'7otis_enriquez@hotmail.com'),
(N'43', N'PETE ', N'REDDING', N'1988-12-17', N'M', N'2', N'p_redding@ccf.org'),
(N'44', N'VAN', N'JACK', N'1967-02-18', N'M', N'8', N'v_jack@hr.org'),
(N'45', N'CYNTHIA ', N'SOSA', N'1989-11-08', N'F', N'8', N'c_sosa@gmail.com'),
(N'46', N'LUCIA ', N'SPICER', N'1952-09-26', N'F', N'7', N'l_spicer@@yahoo.com'),
(N'47', N'TONJA', N'LEPPALA', N'1958-05-20', N'F', N'8', N't_leppala@yahoo.com'),
(N'48', N'RENATO ', N' CREECH', N'1967-11-08', N'M', N'3', N'renato.creech@yahoo.com'),
(N'49', N'DESMOND ', N'JEFFERS', N'1952-05-31', N'M', N'7', N'desmond_jeffers@@hotmail.com'),
(N'50', N'CANDELARIA ', N'WISE', N'1967-08-01', N'F', N'4', N'c_wise@hotmail.com'),
(N'51', N'RORY', N'RODEFER', N'1995-09-19', N'M', N'5', N'rory_rodefer@ffrs.gov'),
(N'52', N'SHERRI', N'CRAWFORD', N'1953-01-24', N'F', N'3', N's_crawford@@yahoo.com'),
(N'53', N'MANUELA ', N'PRUETT', N'1964-10-03', N'F', N'3', N'manuela_pruett@yahoo.com'),
(N'54', N'TASHA ', N'INGRAHAM', N'1965-10-06', N'F', N'1', N't_ingraham@@gmail.com'),
(N'55', N'TAMIKA ', N'ESCOBEDO', N'1951-03-29', N'F', N'3', N't_escobedo@@msv.org'),
(N'56', N'MARTYN ', N'GLEASON', N'1979-06-08', N'M', N'2', N'm_gleason@nnl.com'),
(N'57', N'CHRISTOPHER', N'LANGEVIN', N'1962-11-12', N'M', N'4', N'c_langevin@@hotmail.com'),
(N'58', N'NICHOLAS', N'FORRESTER', N'1996-08-29', N'M', N'6', N'nicholas.forrester@rrg.net'),
(N'59', N'MARITA ', N'ELAM', N'1984-02-21', N'F', N'1', N'm_elam@@yahoo.com'),
(N'60', N'RYAN ', N'HAHN', N'1968-04-20', N'M', N'7', N'ryan_hahn@hotmail.com'),
(N'61', N'CHI ', N'MIMS', N'1963-08-05', N'M', N'7', N'c_mims@@msv.org'),
(N'62', N'SUSAN ', N'VANCE', N'1973-09-07', N'F', N'2', N's_vance@gmail.com'),
(N'63', N'GARETH ', N'ROBERSON', N'1978-04-30', N'M', N'11', N'7g_roberson@nnl.com'),
(N'64', N'GREIG ', N' WALTERS', N'1976-11-03', N'M', N'5', N'g_walters@hotmail.com'),
(N'65', N'ARMANDO ', N'MOSLEY', N'1956-01-01', N'M', N'3', N'a_mosley@hotmail.com'),
(N'66', N'JAYSON', N'MCCLELLAND', N'1967-03-15', N'M', N'3', N'j_mcclelland@yahoo.com'),
(N'67', N'GRANT ', N' DOWDY', N'1955-12-15', N'M', N'21', N'115grant.dowdy@hotmail.com'),
(N'68', N'ALVA ', N'OWEN', N'1971-08-20', N'F', N'5', N'a_owen@hotmail.com'),
(N'69', N'ELDON', N'CRAIG', N'1983-07-15', N'M', N'10', N'9e_craig@gmail.com'),
(N'70', N'BOYCE ', N' WILLIAM', N'1983-12-06', N'M', N'4', N'b_william@hotmail.com'),
(N'71', N'VITO ', N' KANIECKI', N'1965-03-31', N'M', N'4', N'v_kaniecki@hr.org'),
(N'72', N'NAPOLEON ', N' PEDROZO', N'1964-04-07', N'M', N'2', N'n_pedrozo@hotmail.com'),
(N'73', N'DARYL ', N' MASON', N'1977-08-14', N'M', N'5', N'd_mason@fin.gov'),
(N'74', N'LESLIE ', N'BOSTON', N'1995-07-24', N'M', N'3', N'leslie.boston@yahoo.com'),
(N'75', N'MITCHEL ', N'KIM', N'1994-12-29', N'M', N'2', N'm_kim@hotmail.com'),
(N'76', N'BERTA', N'HERMAN', N'1993-05-24', N'F', N'13', N'7b_herman@gmail.com'),
(N'77', N'WILDA ', N'LAMBERT', N'1991-09-03', N'F', N'6', N'w_lambert@yahoo.com'),
(N'78', N'NEVA ', N' CLAY', N'1978-12-26', N'F', N'7', N'n_clay@gmail.com'),
(N'79', N'CHARLES ', N'MACK', N'1975-08-11', N'M', N'3', N'c_mack@hotmail.com'),
(N'80', N'HETTIE ', N'CARMONA', N'1996-06-08', N'F', N'4', N'h_carmona@ccf.org'),
(N'81', N'LUCIEN', N'MURILLO', N'1965-06-24', N'M', N'10', N'9l_murillo@fin.gov'),
(N'82', N'DEVON', N'GOBERN', N'1958-09-02', N'M', N'8', N'd_gobern@ccf.org'),
(N'83', N'KRISTA ', N'EARLY', N'1985-08-21', N'F', N'5', N'k_early@hr.org'),
(N'84', N'GREIG ', N'CONN', N'1993-10-30', N'M', N'6', N'greig_conn@hotmail.com'),
(N'85', N'IRMA', N'MONTANEZ', N'1954-11-27', N'F', N'8', N'i_montanez@gmail.com'),
(N'86', N'JERRELL', N'OHARA', N'1967-05-16', N'M', N'8', N'j_ohara@msv.org'),
(N'87', N'BRANDON', N'YANG', N'1975-10-10', N'M', N'5', N'brandon.yang@gmail.com'),
(N'88', N'MARLENE ', N' SCHUMACHER', N'1987-11-05', N'F', N'4', N'marlene.schumacher@rrg.net'),
(N'89', N'CLEMENTINE ', N' JACKSON', N'1972-06-13', N'F', N'8', N'clementine.jackson@gmail.com'),
(N'90', N'SHAWANDA ', N'CANTU', N'1977-05-02', N'F', N'13', N'7s_cantu@hr.org'),
(N'91', N'TAMIKA ', N'COE', N'1953-09-02', N'F', N'8', N't_coe@fin.gov'),
(N'92', N'ABRAHAM ', N'GATLIN', N'1987-06-19', N'M', N'8', N'abraham.gatlin@hotmail.com'),
(N'93', N'JANE', N'HEDRICK', N'1975-03-05', N'F', N'5', N'j_hedrick@gmail.com'),
(N'94', N'ALONSO', N'HITCHCOCK', N'1968-01-29', N'M', N'8', N'alonso.hitchcock@gmail.com'),
(N'95', N'LEO ', N' VEGA', N'1957-11-17', N'M', N'3', N'l_vega@live.com'),
(N'96', N'TANA ', N'HILLMAN', N'1957-01-20', N'F', N'2', N'tana_hillman@hotmail.com'),
(N'97', N'NELLIE', N'LINDSEY', N'1985-06-05', N'F', N'2', N'n_lindsey@ccf.org'),
(N'98', N'KELLEY', N'DANIEL', N'1966-06-19', N'M', N'7', N'kelley.daniel@gmail.com'),
(N'99', N'MARGARETTE', N'STEM', N'1966-09-12', N'F', N'16', N'130m_stem@ccf.org'),
(N'100', N'KELVIN', N'RULAPAUGH', N'1983-08-23', N'M', N'2', N'k_rulapaugh@gmail.com'),
(N'101', N'MAYRA ', N' SMITH', N'1982-01-17', N'F', N'7', N'm_smith@yahoo.com'),
(N'102', N'JANNA', N'NICKA', N'1980-08-07', N'F', N'7', N'j_nicka@msv.org'),
(N'103', N'PAULINE ', N' NEWCOMB', N'1957-12-07', N'F', N'1', N'p_newcomb@@gmail.com'),
(N'104', N'ELVA ', N' PATTEN', N'1983-04-07', N'F', N'7', N'e_patten@msv.org'),
(N'105', N'SHANE ', N'COLAIZZO', N'1970-05-30', N'M', N'16', N'130s_colaizzo@fin.gov'),
(N'106', N'THERSA', N'ARREDONDO', N'1964-02-02', N'F', N'2', N't_arredondo@@gmail.com'),
(N'107', N'AMPARO ', N' SYKES', N'1960-02-29', N'F', N'16', N'130a_sykes@ccf.org'),
(N'108', N'JORGE ', N'BLACKWELL', N'1955-05-08', N'M', N'7', N'j_blackwell@hotmail.com'),
(N'109', N'TYLER ', N'BOOTH', N'1972-01-26', N'M', N'4', N't_booth@gmail.com'),
(N'110', N'JORGE ', N'WAYMIRE', N'1988-02-17', N'M', N'1', N'jorge_waymire@@ffrs.gov'),
(N'111', N'KENNETH', N'MEIER', N'1984-03-17', N'M', N'5', N'kenneth_meier@ffrs.gov'),
(N'112', N'AUBREY ', N'ERWIN', N'1960-11-01', N'M', N'7', N'a_erwin@yahoo.com'),
(N'113', N'CHARLES ', N'STILES', N'1981-08-25', N'M', N'4', N'c_stiles@gmail.com'),
(N'114', N'LOWELL ', N'BAER', N'1951-08-01', N'M', N'3', N'l_baer@@fin.gov'),
(N'115', N'TRACEY ', N'ONOFRIO', N'1986-01-07', N'F', N'1', N't_onofrio@@ccf.org'),
(N'116', N'STELLA ', N'HIEBER', N'1972-07-23', N'F', N'2', N'stella_hieber@hotmail.com'),
(N'117', N'ROSEANNE ', N'VILLANUEVA', N'1955-06-14', N'F', N'9', N'7roseanne_villanueva@yahoo.com'),
(N'118', N'VALENTIN ', N' PARRISH', N'1978-11-22', N'M', N'2', N'valentin.parrish@rrg.net'),
(N'119', N'TERESITA ', N'RUSH', N'1991-07-05', N'F', N'6', N't_rush@yahoo.com'),
(N'120', N'CAREY ', N'HALEY', N'1979-02-04', N'F', N'5', N'c_haley@yahoo.com'),
(N'121', N'BURT ', N' PLATT', N'1962-02-27', N'M', N'23', N'b_platt@hotmail.com'),
(N'122', N'ZORA ', N'TATE', N'1967-06-23', N'F', N'7', N'zora_tate@jcl.net'),
(N'123', N'PENELOPE', N'ROOT', N'1963-07-16', N'F', N'3', N'penelope.root@@rrg.net'),
(N'124', N'DENNY ', N'MORALES', N'1995-03-21', N'M', N'7', N'denny_morales@hotmail.com'),
(N'125', N'DALE', N'BRANCH', N'1982-04-06', N'M', N'14', N'110d_branch@live.com'),
(N'126', N'LAURENCE ', N'METCALF', N'1956-06-13', N'M', N'7', N'laurence.metcalf@yahoo.com'),
(N'127', N'MERYL ', N'BENNETT', N'1963-04-25', N'F', N'7', N'm_bennett@@nnl.com'),
(N'128', N'BERNARDO', N'RICHEY', N'1951-03-07', N'M', N'7', N'b_richey@@live.com'),
(N'129', N'DAN', N'KINNEY', N'1974-02-12', N'M', N'4', N'd_kinney@hotmail.com'),
(N'130', N'ARCHIE ', N' ATKINSON', N'1970-03-06', N'M', N'4', N'a_atkinson@ccf.org'),
(N'131', N'HUGH ', N' VARRIANO', N'1958-02-10', N'M', N'10', N'9hugh.varriano@gmail.com'),
(N'132', N'SONYA ', N'HOLBROOK', N'1969-12-19', N'F', N'16', N'130s_holbrook@rnl.com'),
(N'133', N'PATRICA ', N'OLSEN', N'1982-09-12', N'F', N'5', N'p_olsen@gmail.com'),
(N'134', N'DELIA ', N'SHOMO', N'1986-12-19', N'F', N'2', N'd_shomo@yahoo.com'),
(N'135', N'CARLA', N'VINSON', N'1958-01-21', N'F', N'7', N'c_vinson@ccf.org'),
(N'136', N'FRANCIS ', N' NGUYEN', N'1986-11-10', N'F', N'13', N'7f_nguyen@live.com'),
(N'137', N'WILLARD ', N' PUTNAM', N'1958-08-28', N'M', N'3', N'w_putnam@gmail.com'),
(N'138', N'TARSHA ', N'WILKINSON', N'1963-04-02', N'F', N'2', N't_wilkinson@@hr.org'),
(N'139', N'DEBBY ', N' DUNLAP', N'1974-01-04', N'F', N'23', N'debby_dunlap@jcl.net'),
(N'140', N'GILDA ', N'PERRY', N'1993-07-20', N'F', N'6', N'g_perry@yahoo.com'),
(N'141', N'GARRY ', N' SANTANA', N'1993-07-02', N'M', N'4', N'g_santana@live.com'),
(N'142', N'NICKOLAS ', N'NUNEZ', N'1994-03-03', N'M', N'7', N'nickolas.nunez@gmail.com'),
(N'143', N'PALMA ', N'GRIER', N'1962-08-24', N'F', N'4', N'p_grier@yahoo.com'),
(N'144', N'RUSSELL ', N' WHITTINGTON', N'1957-09-01', N'M', N'8', N'russell_whittington@hotmail.com'),
(N'145', N'OLIVE', N'SALMON', N'1954-05-07', N'F', N'23', N'o_salmon@ccf.org'),
(N'146', N'GARRETT ', N' BOLLINGER', N'1970-12-19', N'M', N'1', N'g_bollinger@@gmail.com'),
(N'147', N'IGNACIO ', N'COKLEY', N'1955-01-23', N'M', N'6', N'ignacio_cokley@jcl.net'),
(N'148', N'NOBLE ', N'MEINERDING', N'1950-08-21', N'M', N'20', N'7n_meinerding@@ccf.org'),
(N'149', N'THELMA ', N'SKURSKY', N'1959-04-28', N'F', N'5', N't_skursky@@rnl.com'),
(N'150', N'AL ', N'BOWLES', N'1969-02-01', N'M', N'1', N'al.bowles@@hotmail.com'),
(N'151', N'CRAIG ', N' COUSEY', N'1970-02-16', N'M', N'8', N'c_cousey@gmail.com'),
(N'152', N'TRACI ', N' BROOKS', N'1969-02-15', N'F', N'1', N'traci_brooks@@hotmail.com'),
(N'153', N'ISABELLA ', N'WATERMAN', N'1979-01-01', N'F', N'4', N'isabella.waterman@rrg.net'),
(N'154', N'JEROME ', N'JACKSON', N'1956-01-23', N'M', N'4', N'jerome.jackson@rrg.net'),
(N'155', N'SILAS ', N'DIAS', N'1997-02-08', N'M', N'13', N'7s_dias@hotmail.com'),
(N'156', N'TOD', N'CLARKE', N'1964-04-04', N'M', N'7', N't_clarke@ccf.org'),
(N'157', N'DONNELL ', N'MYLES', N'1991-01-02', N'M', N'1', N'd_myles@gmail.com'),
(N'158', N'KEITH ', N' MEADOWS', N'1959-08-08', N'M', N'2', N'k_meadows@live.com'),
(N'159', N'JOHNNIE ', N' PRESTON', N'1957-09-19', N'M', N'4', N'johnnie.preston@gmail.com'),
(N'160', N'NANETTE ', N'TALBOT', N'1994-04-29', N'F', N'4', N'n_talbot@hotmail.com'),
(N'161', N'RENATA ', N'ENGLISH', N'1956-01-03', N'F', N'7', N'r_english@gmail.com'),
(N'162', N'SAMMIE', N'DICKENS', N'1972-07-05', N'F', N'3', N's_dickens@msv.org'),
(N'163', N'ANDRA ', N' CAREY', N'1987-11-27', N'F', N'3', N'a_carey@gmail.com'),
(N'164', N'GREGOR ', N'WOLNY', N'1980-04-30', N'M', N'7', N'g_wolny@yahoo.com'),
(N'165', N'LUTHER ', N' DOYLE', N'1998-04-29', N'M', N'10', N'9l_doyle@gmail.com'),
(N'166', N'ENOLA ', N'AUSTIN', N'1991-11-23', N'F', N'4', N'e_austin@nnl.com'),
(N'167', N'DARIUS ', N'NOBLE', N'1959-12-06', N'M', N'7', N'd_noble@gmail.com'),
(N'168', N'WILTON ', N' SEXTON', N'1982-12-03', N'M', N'2', N'w_sexton@msv.org'),
(N'169', N'KATHY', N'KRAMER', N'1989-02-20', N'F', N'7', N'kathy_kramer@yahoo.com'),
(N'170', N'LUPE ', N'MAILLARD', N'1981-04-23', N'F', N'1', N'lupe_maillard@hotmail.com'),
(N'171', N'LEANNE ', N'NIELSEN', N'1982-06-22', N'F', N'1', N'l_nielsen@gmail.com'),
(N'172', N'SEYMOUR ', N'GROVES', N'1978-05-02', N'M', N'4', N'seymour.groves@rrg.net'),
(N'173', N'GLENNA ', N' FELTON', N'1964-06-21', N'F', N'2', N'g_felton@hotmail.com'),
(N'174', N'LIN ', N'PALAIA', N'1961-12-03', N'F', N'7', N'lin.palaia@yahoo.com'),
(N'175', N'SHANELL ', N'ORTIZ', N'1962-08-29', N'F', N'6', N'shanell_ortiz@jcl.net'),
(N'176', N'NICOLETTE ', N' DAVISON', N'1996-05-17', N'F', N'3', N'n_davison@ccf.org'),
(N'177', N'GREGORIA', N'RYDER', N'1955-09-21', N'F', N'2', N'gregoria.ryder@gmail.com'),
(N'178', N'KARRIE', N'TRUJILLO', N'1990-11-08', N'F', N'1', N'k_trujillo@hr.org'),
(N'179', N'STACEY ', N'SWITZER', N'1955-07-23', N'F', N'2', N'stacey.switzer@hotmail.com'),
(N'180', N'KATHERYN ', N' SPEER', N'1976-02-11', N'F', N'7', N'k_speer@gmail.com'),
(N'181', N'PRUDENCE ', N'HACKETT', N'1950-09-30', N'F', N'10', N'9p_hackett@@hotmail.com'),
(N'182', N'ROSANNE ', N'CORCORAN', N'1977-01-19', N'F', N'1', N'rosanne_corcoran@jcl.net'),
(N'183', N'ROSALIE', N'STEM', N'1985-07-15', N'F', N'1', N'rosalie.stem@hotmail.com'),
(N'184', N'GEORGE ', N' LYONS', N'1984-03-12', N'M', N'6', N'george_lyons@ffrs.gov'),
(N'185', N'JAYNE ', N'HARMAN', N'1982-01-11', N'F', N'2', N'j_harman@yahoo.com'),
(N'186', N'MALLORY ', N' WORRELL', N'1992-01-25', N'F', N'23', N'm_worrell@hotmail.com'),
(N'187', N'CAMERON ', N' NORMAN', N'1974-12-16', N'M', N'7', N'cameron.norman@yahoo.com'),
(N'188', N'BERNARD ', N'CROSBY', N'1977-02-06', N'M', N'6', N'b_crosby@yahoo.com'),
(N'189', N'SHANELL ', N'VILLALOBOS', N'1960-03-19', N'F', N'7', N's_villalobos@yahoo.com'),
(N'190', N'EVELYN ', N'DEMESA', N'1961-06-08', N'F', N'10', N'9e_demesa@live.com'),
(N'191', N'TY ', N'LABRECHE', N'1966-06-25', N'M', N'3', N't_labreche@hotmail.com'),
(N'192', N'BRANDEE ', N' MEANS', N'1962-06-03', N'F', N'6', N'b_means@nnl.com'),
(N'193', N'LARISSA ', N' COTTRELL', N'1957-08-10', N'F', N'5', N'l_cottrell@gmail.com'),
(N'194', N'FRIEDA ', N'BRAND', N'1965-04-28', N'F', N'6', N'frieda_brand@hotmail.com'),
(N'195', N'DANI ', N'GRIFFIN', N'1994-07-24', N'F', N'14', N'110d_griffin@gmail.com'),
(N'196', N'LEE ', N'DOW', N'1960-12-28', N'M', N'11', N'7l_dow@yahoo.com'),
(N'197', N'MEAGAN', N'BRUCE', N'1982-03-20', N'F', N'5', N'm_bruce@live.com'),
(N'198', N'JEANETTE ', N'DOYLE', N'1989-10-14', N'F', N'5', N'jeanette_doyle@jcl.net'),
(N'199', N'ANTHONY ', N'SHAW', N'1977-06-27', N'M', N'5', N'anthony.shaw@rrg.net'),
(N'200', N'ROBYN ', N' ROSA', N'1984-05-13', N'F', N'3', N'r_rosa@msv.org'),
(N'201', N'RANDI ', N' CHAFFINS', N'1979-08-27', N'F', N'4', N'r_chaffins@gmail.com'),
(N'202', N'MARJORIE ', N'BLEDSOE', N'1969-07-13', N'F', N'6', N'm_bledsoe@gmail.com'),
(N'203', N'DALE ', N'PEARSON', N'1975-11-01', N'M', N'4', N'd_pearson@live.com'),
(N'204', N'PAULA', N'BROWER', N'1960-04-09', N'F', N'9', N'7paula_brower@hotmail.com'),
(N'205', N'DEVIN ', N'MEYERS', N'1973-07-01', N'M', N'3', N'd_meyers@nnl.com'),
(N'206', N'CHANTEL ', N'LINDSEY', N'1972-04-14', N'F', N'4', N'chantel_lindsey@ffrs.gov'),
(N'207', N'TOMAS', N'ABERNATHY', N'1958-11-18', N'M', N'2', N't_abernathy@hr.org'),
(N'208', N'KRISTI ', N' CROOK', N'1972-10-16', N'F', N'2', N'k_crook@hr.org'),
(N'209', N'RAMIRO ', N' HIATT', N'1952-05-25', N'M', N'7', N'ramiro.hiatt@@yahoo.com'),
(N'210', N'MARANDA ', N'MEIER', N'1952-08-18', N'F', N'2', N'm_meier@@live.com'),
(N'211', N'HESTER ', N'CARDENAS', N'1975-01-05', N'F', N'8', N'h_cardenas@gmail.com'),
(N'212', N'JOESPH ', N' LANKFORD', N'1993-03-06', N'M', N'5', N'joesph_lankford@hotmail.com'),
(N'213', N'BRANDY ', N' MUELLER', N'1972-02-15', N'F', N'5', N'b_mueller@hotmail.com'),
(N'214', N'MAUD ', N'MORGAN', N'1971-10-19', N'F', N'2', N'm_morgan@gmail.com'),
(N'215', N'IDA', N'GUERRERO', N'1989-11-30', N'F', N'6', N'i_guerrero@hr.org'),
(N'216', N'TOMASA ', N' HANDY', N'1956-12-14', N'F', N'1', N't_handy@hotmail.com'),
(N'217', N'DANNY ', N'WILLARD', N'1953-11-26', N'M', N'23', N'd_willard@hotmail.com'),
(N'218', N'DEMETRA', N'DURHAM', N'1998-05-01', N'F', N'5', N'd_durham@rnl.com'),
(N'219', N'SAUL ', N' PYLE', N'1998-04-26', N'M', N'4', N's_pyle@fin.gov'),
(N'220', N'CECELIA ', N'MCDONALD', N'1968-06-22', N'F', N'6', N'c_mcdonald@nnl.com'),
(N'221', N'JULES ', N'BLACKMAN', N'1979-07-01', N'M', N'4', N'jules_blackman@hotmail.com'),
(N'222', N'DEBBY ', N'NUGENT', N'1958-11-03', N'F', N'4', N'd_nugent@rnl.com'),
(N'223', N'MARTIN', N'JIMENEZ', N'1994-05-05', N'M', N'1', N'm_jimenez@hotmail.com'),
(N'224', N'WARREN ', N' PINTO', N'1973-10-16', N'M', N'8', N'warren.pinto@rrg.net'),
(N'225', N'JUDI ', N'NEWMAN', N'1961-03-15', N'F', N'2', N'j_newman@ccf.org'),
(N'226', N'BORIS ', N'LEBLANC', N'1977-08-28', N'M', N'6', N'boris_leblanc@jcl.net'),
(N'227', N'GERTRUDE ', N' ALFARO', N'1972-01-07', N'F', N'19', N'6g_alfaro@rnl.com'),
(N'228', N'JONATHON', N'DELASANCHA', N'1952-06-17', N'M', N'5', N'jonathon.delasancha@@rrg.net'),
(N'229', N'LIZABETH', N'HUMPHREY', N'1998-02-08', N'F', N'7', N'l_humphrey@ccf.org'),
(N'230', N'KATHI ', N'FULTON', N'1977-06-10', N'F', N'1', N'k_fulton@yahoo.com'),
(N'231', N'DENIS', N'BUCK', N'1966-06-05', N'M', N'3', N'd_buck@hotmail.com'),
(N'232', N'BRET ', N' ACUFF', N'1951-01-26', N'M', N'5', N'b_acuff@@hotmail.com'),
(N'233', N'BEULAH ', N' OSTOLAZA', N'1955-10-13', N'F', N'7', N'b_ostolaza@msv.org'),
(N'234', N'RODOLFO ', N' MERCADO', N'1954-02-11', N'M', N'7', N'r_mercado@yahoo.com'),
(N'235', N'LEONARDO ', N' CONNER', N'1998-05-16', N'M', N'3', N'l_conner@live.com'),
(N'236', N'ARTHUR ', N'YUM', N'1957-03-26', N'M', N'4', N'a_yum@yahoo.com'),
(N'237', N'MARSHALL ', N' CHANG', N'1984-08-01', N'M', N'8', N'm_chang@gmail.com'),
(N'238', N'CHUN', N'RYAN', N'1974-03-02', N'F', N'5', N'c_ryan@yahoo.com'),
(N'239', N'JACK', N'GRUBB', N'1973-01-06', N'M', N'3', N'j_grubb@hr.org'),
(N'240', N'BLANCH ', N'HARDING', N'1987-07-08', N'F', N'7', N'b_harding@fin.gov'),
(N'241', N'ANGEL ', N' JERNIGAN', N'1962-01-20', N'F', N'6', N'a_jernigan@ccf.org'),
(N'242', N'STEPHAINE ', N'FARRELL', N'1978-12-10', N'F', N'23', N's_farrell@yahoo.com'),
(N'243', N'ELIJAH ', N'SNOW', N'1990-01-07', N'M', N'23', N'e_snow@yahoo.com'),
(N'244', N'RORY ', N'HENGEL', N'1996-05-22', N'M', N'7', N'r_hengel@hotmail.com'),
(N'245', N'JOSEFINA ', N'CHRISTIAN', N'1997-01-16', N'F', N'5', N'josefina.christian@yahoo.com'),
(N'246', N'JANNA ', N'HILLS', N'1995-10-14', N'F', N'5', N'janna_hills@hotmail.com'),
(N'247', N'QUINCY ', N' LAMBERT', N'1977-09-21', N'M', N'2', N'quincy_lambert@hotmail.com'),
(N'248', N'JERRY ', N' DARLING', N'1980-02-25', N'F', N'6', N'j_darling@ccf.org'),
(N'249', N'SUSIE ', N'CARDONA', N'1986-03-11', N'F', N'7', N'susie_cardona@yahoo.com'),
(N'250', N'ALEXANDRIA ', N'SMALLS', N'1980-05-17', N'F', N'6', N'alexandria.smalls@hotmail.com'),
(N'251', N'DESMOND ', N'STONE', N'1991-03-28', N'M', N'20', N'7d_stone@gmail.com');
INSERT INTO [dbo].[Gender] ([GenderId], [Gender]) VALUES (1, N'Мужчина'),
(2, N'Женщина');
INSERT INTO [dbo].[Runner] ([RunnerId], [Email], [Gender], [DateOfBirth], [CountryCode]) VALUES (1, N'a.bitsuie@ramoz.com', 1, N'2001-12-11', 76)

---------------------------------
INSERT INTO [dbo].[Charity] ([CharityId], [ChatityName], [CharityDescription], [CharityLogo]) VALUES (1, N'ARISE', N'«Arise» поддерживает женщин и детей, которые пережили насилие в семье, что позволяет им 
вернуться к нормальной жизни. Влияние насилия в семье имеет далеко идущие последствия, и 
влияет на всю семью и может продолжаться в течение нескольких поколений.
На протяжении более 20 лет, ARISE оказывает услуги, которые включают:
Оценка риска и поиск безопасное проживание
Предоставление информации о бытовых услуг, юридические консультации, финансовые 
консультации, услуги здравоохранения и группу поддержки
правовую и судебную поддержку
Поддержка ARISE обеспечивает лучшее будущее для женщин и детей.
', N'arise-logo'),
(2, N'Aves Do Brasil', N'Вы можете помочь спасти птиц, которые находятся на грани исчезновения, и под угрозой 
исчезновения в дикой природе.
Находящиеся под угрозой исчезновения птицы включают в себя: Крапивник, вишневые горлом и 
земельную кукушку.
Ваши пожертвования могут помочь защитить в Бразилии регион Серрадо, уникальный район 
саванны, где многие в видов риска, найдены', N'aves-do-brazil-logo'),
(3, N'Clara Santos Oliveira Institute', N'Является неправительственной, некоммерческой организацией, основанной в Сан-Паулу. 
Клара основал институт в 1986 году, чтобы обеспечить жильем и образование для молодых 
людей, которые прошли через суд по делам несовершеннолетних. На сегодняшний день 
существует пять домов в Сан-Паулу, и мы хотим, расширить и построить еще три к 2020 году', N'clara-santos-oliveira-institute-logo'),
(4, N'Conquer Cancer Brazil', N'Посвящен помощи разработки лечения и создания препаратов для лечения рака 
путем финансирования исследований мирового класса в Бразилии. Мы поднимаем средства 
исключительно для исследований в области профилактики, диагностики и лечения для всех видов 
рака, в центрах по всей Бразилии.
Помогите нам работать, чтобы изменить жизнь миллионов людей к 2020.
', N'conquer-cancer-brazil'), (5, N'Diabetes Brazil', N'Стремится снизить влияние диабета посредством образования, раннего выявления и поддержки.
Диабет является ведущей причиной слепоты у взрослых, почечной недостаточности и повышает 
риск сердечных приступов и инсультов до 400%.
Ваша поддержка помогает нам продолжать нашу спасательную работу', N'diabetes-brazil-logo'),
(6, N'Heart Health Sao Paulo', N'Уже более 50 лет, Heart Health Sao Paulo была посвящена спасению жизней, сделав разницу в 
здоровье сердца наших людей. Пожертвования помогают нам финансировать ценные 
исследования, разработать руководящие принципы для медицинских работников, поддерживать 
ухода за пациентами и помочь людям жить здоровым образом жизни.
', N'heart-health-sao-paulo-logo'),
(7, N'Human Rights Centre - Sao Paulo', N'Центр по правам человека защищает и продвигает права человека в Бразилии и в бразильских 
деятельности за рубежом. Это делается через суд, пропаганды и научных исследований. HRC
является независимой, некоммерческой, неправительственной организацией и является 
зарегистрированной благотворительной организацией.
Мы работаем с общественными организациями, юридическими фирмами, ученых и других 
специалистов в области внутренних и международных прав человека.
', N'human-rights-centre-logo'),
(8, N'Stay Pumped', N'Является благотворительной организацией, которая помогает пенсионерам профессионального 
спортивна, которые часто испытывают проблемы, с приспособлением к жизни после спорта. 
Многим пенсионерам, не хватает образования и жизненных необходимых навыков,. Они часто 
имеют дополнительное бремя по полученным травмам.
Мы работаем с профессионалами и добровольцами. Мы полагаемся на пожертвования, чтобы 
выполнить эту необходимую работу.
', N'stay-pumped-logo'),
(9, N'Upbeat SP', N'Является некоммерческой организацией, которая предлагает поддержку для тех, кто 
страдает от расстройств настроения, таких как депрессия и биполярное расстройство. Кроме того 
мы проводим научные исследования, чтобы помочь с пониманием расстройств настроения. Наш 
последний проект помогает использовать технологии, чтобы решить проблемы психического 
здоровья. Мы смотрим на социальных медиа в качестве индикатора психического здоровья, а 
также на использовании мобильных телефонов для измерения психического здоровья.
Помогите нам продолжить большую работу мы делаем', N'upbeat-logo'),
(10, N'WWSM Rescue', N'Небольшой организация WWSM посвятила себя сохранению Белый Усатой Паукообразной
Обезьяны. Вырубка лесов и превращение земли для сельского хозяйства серьезно сказалось на 
доме для этой обезьяны. К сожалению, на них также охотились и они были вытеснены на грань 
вымирания.
WWSM нуждается в вашей помощи, чтобы поднять профиль Белый Усатой Паукообразной
Обезьяны в местных сообществах', N'wwsm-rescue-logo'),
(11, N'The Red Cross', N'Помощи в период кризиса, все равно, когда она наиболее необходима, и обязательства, когда 
другие отворачиваются. Красный Крест там для людей в потребности, независимо от того, кто вы 
есть, независимо от того, где вы живете.
Красного Полумесяца движение Красного Креста помогает десятки миллионов людей по всему 
миру каждый год, и мы также заботимся для местных общин в нашей стране местного и дальнего 
зарубежья.
С миллионами добровольцев по всему миру и тысячи членов, волонтеров и сторонников, мы 
можем достичь людей и места, как никто другой.
', N'the-red-cross-logo'),
(12, N'Oxfam International', N'Oxfam является Международной конфедерацией 17 организаций, работающих совместно 
с партнерами и местными сообществами в более чем 90 странах мира.
Один человек из трех в мире живет в нищете. Oxfam решил изменить этот мир по 
мобилизации сил народа против бедности.
На всем земном шаре, Oxfam работает, чтобы найти практические пути, инновационные 
для людей, чтобы вырваться из нищеты и процветать. Мы спасаем жизнь и помогаем
восстановить средства к существованию, в период кризиса и забастовок. И мы кампания, так что 
голоса бедных влияния на локальные и глобальные решения, которые их затрагивают.
Во всех мы делаем, Oxfam работает с партнерскими организациями и рядом уязвимых 
женщин и мужчин до конца несправедливости, которые вызывают бедность.
', N'oxfam-international-logo'),
(13, N'Save the Children Fund', N'Является ведущей в мире независимой организацией для детей. Мы работаем примерно в 120 
странах мира. Мы спасаем жизни детей; мы боремся за свои права; мы помогаем им реализовать 
свой потенциал.
Мы работаем, чтобы вдохновить прорывов в том, как мир относится к детям и добиться 
немедленного и прочного изменения в их жизни. По всей нашей работы, мы преследуем 
несколько основных значения: подотчетность, амбиции, сотрудничество, творчество и 
целостность.
В 2014 году мы достигли более 55 миллионов детей непосредственно через работы наших и 
наших партнеров.
Пожертвовать сейчас, чтобы помочь нам, как дети мира', N'save-the-children-fund-logo'),
(14, N'Querstadtein Berlin', N'querstadtein первый проект Stadtsichten , зарегистрированного некоммерческого объединения.
Хотя видно везде в городе, бездомность редко обсуждается. На теоретическом уровне мы часто 
очень мало знаем о теме, которая перед нами на улицах каждый день. Через querstadtein мы 
хотели бы повысить осведомленность о данной проблеме.
Все началось с желания наших двух основателей, чтобы получить что-то "реальное" с земли в 
Берлине, активно решать проблему, а не просто думать об этом. Бездомные люди, казалось, 
везде, по всему городу и на ежедневных поездок в офис. Некоторые из них были там в день, день, 
в U-Bahn или на улице. Разрыв между бездомных и остальной части общества было 
поразительным. Это где мы хотели быть активным - создать пространство, которое будет 
способствовать встречи, обмен и осведомленность.
Мы хотели бы вашей помощи, чтобы помочь бездомным в Берлине', N'querstadtein-logo');
INSERT INTO [dbo].[RaceKitOption] ([RaceKitOptionId], [RaceKitIption], [Cost]) VALUES (1, N'Номер бегуна + RFID браслет', 0),
(2, N'Вариант А + бейсболка + бутылка воды', 20),
(3, N'Вариант В + футболка + сувенирный браслет', 45);
INSERT INTO [dbo].[RegistrationStatus] ([RegistrationStatusId], [RegistrationStatus]) VALUES (1, N'Зарегестрирован'),
 (2, N'Подтверждена оплата'),
 (3, N'Выдан пакет'),
 (4, N'Вышел на старт');
 INSERT INTO [dbo].[Regisrtation] ([RegistrationId], [RannerId], [RegistrationDateTime], [RaceKitOption], [RegistrationStatus], [Cost], [Charity]) VALUES (1, 1, N'2021-11-11 00:00:00', 1, 1, 20, 1);
