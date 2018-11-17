import pandas as pd
from collections import defaultdict
from random import sample, randrange, shuffle
from surprise import SVD, accuracy, Reader, Dataset, NormalPredictor, BaselineOnly
from surprise.model_selection import cross_validate
from surprise.model_selection import train_test_split

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

        x = [ i for i in range(50)]*5
        y = x.copy()
        shuffle(x)
        shuffle(y)

        self.ratings_dict = { 'projectID': x,
                                                'userID': y,
                                                'rating': [randrange(1, 6) for _ in range(0, 250)],
                                            }
        self.ratings_dict_u = { 'userID': x,
                                                'userID2': y,
                                                'rating': [randrange(1, 6) for _ in range(0, 250)],
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
        # print(first+second+third)
        ppu_pom = self.df_p.loc[(self.df_p[first] > 8.0) & ((self.df_p[second] > 6.0) | (self.df_p[third] > 6.0))]
        mpppu = ppu_pom.sort_values([first], ascending=False)
        return mpppu.index.values

    def get_top_n(self, predictions, n=10):
        top_n = defaultdict(list)
        for uid, iid, true_r, est, _ in predictions:
            top_n[uid].append((iid, est))

        for uid, user_ratings in top_n.items():
            user_ratings.sort(key=lambda x: x[1], reverse=True)
            top_n[uid] = user_ratings[:n]

        return top_n

    def usp_(self, userID, type):
        
        # print(df.head())
        if(type == 'p'):
           df = pd.DataFrame(self.ratings_dict)
        else:
            df = pd.DataFrame(self.ratings_dict_u)
        reader = Reader(rating_scale=(1, 5))
        data = Dataset.load_from_df(df[list(df.columns)], reader)
        trainset, testset = train_test_split(data, test_size=.25)

        algo = SVD()

        algo.fit(trainset)
        predictions = algo.test(testset)
        
        top_n = self.get_top_n(predictions, n=5)

        # Print the recommended items for each user
        for uid, user_ratings in top_n.items():
            if(uid == userID):
                return [uid, [iid for (iid, _) in user_ratings]]

        accuracy.rmse(predictions)


# rc = Recommender()
# rc.usp_(3, 'u')