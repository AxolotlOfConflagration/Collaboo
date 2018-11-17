import pandas as pd
from random import sample, randrange
# from itertools import izip

class Recommender:
    def __init__(self):
        d = {
        'python' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'csharp' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'cpp' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'java' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'javascript' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'haskel' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'c' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'r' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'php' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'swift' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'assembly' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'go' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'ruby' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'perl' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50))
         }

        p = {
        'python' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'csharp' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'cpp' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'java' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'javascript' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'haskel' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'c' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'r' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'php' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'swift' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'assembly' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'go' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'ruby' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50)),
        'perl' : pd.Series([randrange(1, 11) for _ in range(0, 50)], index=sample(range(100), 50))
         }

        self.df = pd.DataFrame(d)
        self.df_p = pd.DataFrame(p)
        # print(self.df.head())
        # print(self.df.shape)

        self.df_columns = list(self.df.columns)
        self.df_p_columns = list(self.df_p)

    def mpl(self):
        # most popular languages
        most_popular_dict = { key: self.df[key].mean() for key in self.df_columns }
        mpl= sorted(most_popular_dict.items(), key=lambda kv: kv[1], reverse=True)
        return mpl[:5]
        
    def ppu(self, userID):
        # project per user
        user_info = self.df.loc[[userID]].fillna(0)
        ui = user_info.values.tolist()
        ui = sum(ui, [])
        ui_indexes = user_info.columns.tolist()
        ui_all = dict(zip(ui_indexes, ui))
        ui = sorted(ui_all.items(), key=lambda kv: kv[1], reverse=True)[:3]
        first, second, third = ui[0][0], ui[1][0], ui[2][0]
        print(first+second+third)
        ppu_pom = self.df_p.loc[(self.df_p[first] > 8.0) & ((self.df_p[second] > 6.0) | (self.df_p[third] > 6.0))]
        mpppu = ppu_pom.sort_values([first], ascending=False)
        return mpppu.index.values



rc = Recommender()
rc.ppu(3)