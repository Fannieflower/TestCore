using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	public class InfErpOrderInfoVOHelper : TBeanSerializer<InfErpOrderInfoVO>
	{
		
		public static InfErpOrderInfoVOHelper OBJ = new InfErpOrderInfoVOHelper();
		
		public static InfErpOrderInfoVOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InfErpOrderInfoVO structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("infErpMRetail".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.order.common.pojo.vo.InfErpMRetailVO value;
						
						value = new com.vip.xstore.order.common.pojo.vo.InfErpMRetailVO();
						com.vip.xstore.order.common.pojo.vo.InfErpMRetailVOHelper.getInstance().Read(value, iprot);
						
						structs.SetInfErpMRetail(value);
					}
					
					
					
					
					
					if ("infErpMRetailItemList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO> value;
						
						value = new List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO elem2;
								
								elem2 = new com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO();
								com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVOHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetInfErpMRetailItemList(value);
					}
					
					
					
					
					
					if ("infErpMRetailPayItemList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO> value;
						
						value = new List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO elem4;
								
								elem4 = new com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO();
								com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVOHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetInfErpMRetailPayItemList(value);
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
		
		
		public void Write(InfErpOrderInfoVO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetInfErpMRetail() != null) {
				
				oprot.WriteFieldBegin("infErpMRetail");
				
				com.vip.xstore.order.common.pojo.vo.InfErpMRetailVOHelper.getInstance().Write(structs.GetInfErpMRetail(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfErpMRetailItemList() != null) {
				
				oprot.WriteFieldBegin("infErpMRetailItemList");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO _item0 in structs.GetInfErpMRetailItemList()){
					
					
					com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVOHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfErpMRetailPayItemList() != null) {
				
				oprot.WriteFieldBegin("infErpMRetailPayItemList");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO _item0 in structs.GetInfErpMRetailPayItemList()){
					
					
					com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVOHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InfErpOrderInfoVO bean){
			
			
		}
		
	}
	
}