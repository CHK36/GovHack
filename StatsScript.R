#################### Workspace ################################

setwd("C:/Users/-----/Desktop/Flags R")
getwd()

#################### Loading Census Data ######################

popdata <- read.csv("Pop.csv", stringsAsFactors = FALSE)
head(popdata)

regions <- popdata[, 1]
pops <- popdata[ , 2]

pops <- as.numeric(pops) ## converting char to num

################## Flags Text File #############################

## Change This
flagdata <- read.csv("C:/Users/-----/Desktop/Flags R/Raw Data/2AuckandFlags.txt", header = FALSE)

Artists <- unique(flagdata[, 3])

length(Artists)

Submissions <- numeric()

for (i in 1:length(Artists)) {
      Submissions = c(Submissions, 0)
}

for (i in 1:nrow(flagdata)) {
      
      for (j in 1:length(Artists)) {
            
            if (flagdata[i, 3] == Artists[j]) {
                  
                  if (Submissions[j] == 0) {
                        Submissions[j] = 1
                        
                  } else {
                        Submissions[j] = Submissions[j] + 1
                  }
                  
            }
      } 
}


rankings <- data.frame(Artists, Submissions)

ndex <- order(rankings$Submissions, decreasing = TRUE)

rankingsorted <- rankings[ndex,]

## Change This
write.csv(rankingsorted, "C:/Users/-----/Desktop/Flags R/Tidy Data/Auckland.txt")

## Change This
write.table(paste("Number of Artists: ", length(Artists)), "C:/Users/------/Desktop/Flags R/Tidy Data/Auckland.txt", append = TRUE, col.names = FALSE)

## Change This
write.table(paste("Number of Submissions: ", nrow(flagdata)), "C:/Users/------/Desktop/Flags R/Tidy Data/Auckland.txt", append = TRUE, col.names = FALSE)

region <- "Auckland" ## Change this

population <- popdata[popdata[, 1] == region, 2]

population

## Change This
write.table(paste("Entries Per Person in City: ", (nrow(flagdata)/population)), "C:/Users/-----/Desktop/Flags R/Tidy Data/Auckland.txt", append = TRUE, col.names = FALSE)

## Change This
write.table(paste("Ratio of Artists to People in City: ", (length(Artists)/population)), "C:/Users/-----/Desktop/Flags R/Tidy Data/Auckland.txt", append = TRUE, col.names = FALSE)
