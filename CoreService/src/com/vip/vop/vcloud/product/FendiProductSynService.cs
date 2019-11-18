using System;
using System.Collections.Generic;

namespace com.vip.vop.vcloud.product{
	
	
	public interface FendiProductSynService {
		
		
		void handleImages();
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		void parseAndSave();
		
		void parseAndSaveCategory();
		
		void pushCategoryToVdg();
		
	}
	
}