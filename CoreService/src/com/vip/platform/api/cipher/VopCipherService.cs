using System;
using System.Collections.Generic;

namespace com.vip.platform.api.cipher{
	
	
	public interface VopCipherService {
		
		
		com.vip.platform.api.cipher.BatchCipherResp batchDecrypt( com.vip.platform.api.cipher.BatchDecryptReq req_ );
		
		com.vip.platform.api.cipher.BatchCipherResp batchEncrypt( com.vip.platform.api.cipher.BatchEncryptReq req_ );
		
		void createAllStoreKey();
		
		com.vip.platform.api.cipher.CreateKeyResp createKey( com.vip.platform.api.cipher.CreateKeyReq req_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}