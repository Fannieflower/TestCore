using System;
using System.Collections.Generic;

namespace com.vip.xstore.user.face.service.photorecord{
	
	
	public interface XstorePhotoRecordService {
		
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordResponse uploadPhotos( com.vip.xstore.user.face.service.photorecord.XstorePhotoRecordRequest request_ );
		
	}
	
}