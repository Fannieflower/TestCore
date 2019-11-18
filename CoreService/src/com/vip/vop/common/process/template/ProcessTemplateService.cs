using System;
using System.Collections.Generic;

namespace com.vip.vop.common.process.template{
	
	
	public interface ProcessTemplateService {
		
		
		com.vip.vop.common.process.template.CreateProcessTemplateResp createProcessTemplate( com.vip.vop.common.process.template.CreateProcessTemplateReq createProcessTemplateReq_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.vop.common.process.template.UpdateProcessTemplateResp updateProcessTemplate( com.vip.vop.common.process.template.UpdateProcessTemplateReq updateProcessTemplateReq_ );
		
	}
	
}