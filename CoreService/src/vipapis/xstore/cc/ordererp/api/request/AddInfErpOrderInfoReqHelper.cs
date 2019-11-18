using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.ordererp.api.request{
	
	
	
	public class AddInfErpOrderInfoReqHelper : TBeanSerializer<AddInfErpOrderInfoReq>
	{
		
		public static AddInfErpOrderInfoReqHelper OBJ = new AddInfErpOrderInfoReqHelper();
		
		public static AddInfErpOrderInfoReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AddInfErpOrderInfoReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("erpOrderList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO> value;
						
						value = new List<com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO elem0;
								
								elem0 = new com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO();
								com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVOHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetErpOrderList(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(AddInfErpOrderInfoReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetErpOrderList() != null) {
				
				oprot.WriteFieldBegin("erpOrderList");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO _item0 in structs.GetErpOrderList()){
					
					
					com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVOHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AddInfErpOrderInfoReq bean){
			
			
		}
		
	}
	
}